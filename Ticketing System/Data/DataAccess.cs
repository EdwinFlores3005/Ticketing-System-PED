using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ticketing_System.Models;

namespace Ticketing_System.Data
{
    public static class DataAccess
    {
        public static void InitializeDatabase()
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                // USERS
                string usersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Email TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Role TEXT NOT NULL
            );";

                var createUsers = new SqliteCommand(usersTable, db);
                createUsers.ExecuteNonQuery();

                // TICKETS
                string ticketsTable = @"
            CREATE TABLE IF NOT EXISTS Tickets (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Description TEXT NOT NULL,
                Status TEXT NOT NULL,
                CreatedAt TEXT NOT NULL,
                Priority INTEGER NOT NULL,
                CreatedByUserId INTEGER,
                AssignedToUserId INTEGER,
                FOREIGN KEY (AssignedToUserId) REFERENCES Users(Id),
                FOREIGN KEY (CreatedByUserId) REFERENCES Users(Id)
            );";

                var createTickets = new SqliteCommand(ticketsTable, db);
                createTickets.ExecuteNonQuery();

                //TICKET HISTORY
                string historyTable = @"
            CREATE TABLE IF NOT EXISTS TicketHistory (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                TicketId INTEGER NOT NULL,
                Change TEXT NOT NULL,
                CreatedAt TEXT NOT NULL,
                UpdatedById INTEGER NOT NULL,
                FOREIGN KEY (TicketId) REFERENCES Tickets(Id)
                FOREIGN KEY (UpdatedById) REFERENCES Users(Id)
            );";

                var createHistory = new SqliteCommand(historyTable, db);
                createHistory.ExecuteNonQuery();
                db.Close();
            }
        }

        public static void AddTicket(string title, string description, string email, int priority)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                // Buscar el usuario por email
                string getUserQuery = "SELECT Id FROM Users WHERE Email = @email";
                using var getUserCmd = new SqliteCommand(getUserQuery, db);
                getUserCmd.Parameters.AddWithValue("@email", email);

                var userId = getUserCmd.ExecuteScalar();

                // Validación simple
                if (userId == null)
                {
                    throw new Exception("El usuario con ese email no existe");

                }

                // Insertar ticket con ese UserId
                string insertQuery = @"
        INSERT INTO Tickets (Title, Description, Status, CreatedAt, Priority, CreatedByUserId, AssignedToUserId)
        VALUES (@title, @description, @status, @createdAt, @priority, @userId, @agentId);";

                using var insertCmd = new SqliteCommand(insertQuery, db);

                insertCmd.Parameters.AddWithValue("@title", title);
                insertCmd.Parameters.AddWithValue("@description", description);
                insertCmd.Parameters.AddWithValue("@status", "New");
                insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                insertCmd.Parameters.AddWithValue("@priority", priority);
                insertCmd.Parameters.AddWithValue("@userId", userId);
                insertCmd.Parameters.AddWithValue("@agentId", 1);


                insertCmd.ExecuteNonQuery();

                db.Close();
            }
        }

      

        //Retornar todos los tickets
        public static List<Ticket> GetTickets(string where)
        {
            List<Ticket> list = new List<Ticket>();

            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
               SELECT  
            T.Id AS TicketId,
            T.Title,
            T.Description,
            T.Status,
            T.Priority,
            T.CreatedAt,
            T.CreatedByUserId,
            T.AssignedToUserId,
            U.Name AS UserName,
            U.Email AS UserEmail,
            A.Name AS AssignedAgentName
            FROM Tickets T
            LEFT JOIN Users U
            ON T.CreatedByUserId = U.Id
            LEFT JOIN Users A
            ON T.AssignedToUserId = A.Id
            " + where;

                using var command = new SqliteCommand(query, db);
                if (where.Contains("@userId"))
                {
                    command.Parameters.AddWithValue(
                        "@userId",
                        Session.id
                    );
                }

                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ticket ticket = new Ticket();

                    ticket.Id = Convert.ToInt32(reader["TicketId"]);

                    ticket.Title = reader["Title"].ToString();

                    ticket.Description = reader["Description"].ToString();

                    ticket.Status = reader["Status"].ToString();

                    ticket.Priority = Convert.ToInt32(reader["Priority"]);

                    ticket.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);

                    ticket.CreatedByUserId = Convert.ToInt32(reader["CreatedByUserId"]);

                    if (reader["AssignedToUserId"] != DBNull.Value)
                    {
                        ticket.AssignedToUserId =
                            Convert.ToInt32(reader["AssignedToUserId"]);
                    }

                    ticket.UserName = reader["UserName"].ToString();

                    ticket.UserEmail = reader["UserEmail"].ToString();

                    ticket.AssignedAgentName = reader["AssignedAgentName"].ToString();

                    list.Add(ticket);
                }
            }

            return list;
        }

        /*public static int Login(TextBox username, TextBox password)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @user AND Password = @pass";

                using var command = new SqliteCommand(query, db);
                command.Parameters.AddWithValue("@user", username.Text);
                command.Parameters.AddWithValue("@pass", password.Text);

                int result = Convert.ToInt32(command.ExecuteScalar());
                return result;

            }
        }*/



        public static bool  Login(string username, string password)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = "SELECT Id, Name, Email, Role FROM Users WHERE Email = @user AND Password = @pass";

                using var command = new SqliteCommand(query, db);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@pass", password);

                using var reader = command.ExecuteReader();

                if(reader.Read())
                {
                    Session.id = Convert.ToInt32(reader["Id"]);
                    Session.name = reader["Name"].ToString();
                    Session.email = reader["Email"].ToString();
                    Session.role = reader["Role"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
                

            }
        }

        public static void LoadTicket(int ticketId, Label title, Label user, Label email, Label agent, ComboBox state, ComboBox priority, TextBox description, TextBox usertime)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
            SELECT  
                T.Id AS TicketId, 
                T.Title AS Title, 
                T.Status AS Status, 
                T.Description AS Description, 
                CASE T.Priority 
                    WHEN 1 THEN 'Crítico' 
                    WHEN 2 THEN 'Alta' 
                    WHEN 3 THEN 'Media' 
                    WHEN 4 THEN 'Baja' 
                END AS Priority,
                strftime ('%e/%m/%Y %H:%M', T.CreatedAt) AS CreatedDate,
                U.Name AS UserName, 
                U.Email AS UserEmail, 
                A.Name AS Agent
            FROM Tickets T 
            LEFT JOIN Users U 
                ON T.CreatedByUserId = U.Id
            LEFT JOIN Users A 
                ON T.AssignedToUserId = A.Id
            WHERE T.Id = @id";

                using var cmd = new SqliteCommand(query, db);
                cmd.Parameters.AddWithValue("@id", ticketId);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    title.Text = reader["Title"].ToString();
                    user.Text = reader["UserName"].ToString();
                    email.Text = reader["UserEmail"].ToString();
                    agent.Text = reader["Agent"].ToString();
                    state.Text = reader["Status"].ToString();
                    priority.Text = reader["Priority"].ToString();
                    description.Text = reader["Description"].ToString();
                    usertime.Text = reader["Username"].ToString().Split(' ')[0] + " | " + reader["CreatedDate"].ToString(); //esto lo podria separar en dos textboxes
                }
            }
        }

        
    }

}
