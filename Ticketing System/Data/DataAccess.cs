using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
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

        public static void AddTicket(string title, string description, string email, int priority, string status)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                int userId = GetOrCreateUser(email);

                string insertQuery = @"
        INSERT INTO Tickets
        (
            Title,
            Description,
            Status,
            CreatedAt,
            Priority,
            CreatedByUserId,
            AssignedToUserId
        )
        VALUES
        (
            @title,
            @description,
            @status,
            @createdAt,
            @priority,
            @userId,
            @agentId
        );";

                using var insertCmd =
                    new SqliteCommand(insertQuery, db);

                insertCmd.Parameters.AddWithValue("@title", title);

                insertCmd.Parameters.AddWithValue("@description", description);

                insertCmd.Parameters.AddWithValue("@status", status);

                insertCmd.Parameters.AddWithValue(
                    "@createdAt",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                );

                insertCmd.Parameters.AddWithValue("@priority", priority);

                insertCmd.Parameters.AddWithValue("@userId", userId);

                insertCmd.Parameters.AddWithValue("@agentId", Session.id);

                insertCmd.ExecuteNonQuery();
            }
        }

        public static int GetOrCreateUser(string email)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string getUserQuery = "SELECT Id FROM Users WHERE Email = @email";

                using var getUserCmd = new SqliteCommand(getUserQuery, db);

                getUserCmd.Parameters.AddWithValue("@email", email);

                var result = getUserCmd.ExecuteScalar();

                // Usuario existe
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                // Crear customer automáticamente
                string insertUserQuery = @"INSERT INTO Users (Name, Email, Password, Role) VALUES
                (
                    @name,
                    @email,
                    '',
                    'Cliente'
                );

                SELECT last_insert_rowid();";

                using var insertCmd = new SqliteCommand(insertUserQuery, db);

                string name = email.Split('@')[0];

                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@email", email);

                int newUserId = Convert.ToInt32(insertCmd.ExecuteScalar());

                return newUserId;
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
                    command.Parameters.AddWithValue("@userId",Session.id);
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

        
        public static Ticket GetSelectedTicket(int ticketId)
        {
            Ticket ticket = null;

            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                SELECT  
                T.Id AS Id,
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
                WHERE T.Id = @id";

                using var cmd = new SqliteCommand( query, db);
                cmd.Parameters.AddWithValue("@id", ticketId);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ticket = new Ticket();
                    ticket.Id = Convert.ToInt32(reader["Id"]);
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
                }

            }

                return ticket;
        }

        public static void UpdateTicket(int ticketId, string status, int priority, int assignedToUserId)
        //Aqui se puede agregar para modificar el agente a futuro
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                UPDATE Tickets
                SET
                    Status = @status,
                    Priority = @priority,
                    AssignedToUserId = @agentId
                WHERE Id = @ticketId";

                using var cmd = new SqliteCommand(query, db);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@agentId",assignedToUserId);
                cmd.Parameters.AddWithValue("@ticketId", ticketId);
                cmd.ExecuteNonQuery();
                db.Close();
            }
        }

        public static void AddHistory(int ticketId, string change, int updatedById)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                INSERT INTO TicketHistory
                (TicketId, Change, CreatedAt,UpdatedById)
                VALUES
                (@ticketId, @change, @createdAt, @updatedById)";

                using var cmd = new SqliteCommand(query, db);

                cmd.Parameters.AddWithValue("@ticketId", ticketId);
                cmd.Parameters.AddWithValue("@change", change);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@updatedById", updatedById);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<TicketHistory> GetTicketHistory(int ticketId)
        {
            List<TicketHistory> historyList = new List<TicketHistory>();

            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                SELECT
                    H.Id,
                    H.TicketId,
                    H.Change,
                    H.CreatedAt,
                    H.UpdatedById,
                    U.Name AS UpdatedByName
                FROM TicketHistory H
                LEFT JOIN Users U
                    ON H.UpdatedById = U.Id
                WHERE H.TicketId = @ticketId
                ORDER BY H.CreatedAt ASC";

                using var cmd = new SqliteCommand(query, db);

                cmd.Parameters.AddWithValue("@ticketId", ticketId);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TicketHistory history = new TicketHistory();
                    history.Id = Convert.ToInt32(reader["Id"]);
                    history.TicketId = Convert.ToInt32(reader["TicketId"]);
                    history.Change = reader["Change"].ToString();
                    history.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
                    history.UpdatedById = Convert.ToInt32(reader["UpdatedById"]);
                    history.UpdatedByName = reader["UpdatedByName"].ToString();

                    historyList.Add(history);
                }
            }

            return historyList;
        }

        public static Queue<TicketHistory> GetTicketHistoryQueue(int ticketId)
        {
            List<TicketHistory> historyList = GetTicketHistory(ticketId);

            Queue<TicketHistory> historyQueue = new Queue<TicketHistory>();

            foreach (TicketHistory history in historyList)
            {
                historyQueue.Enqueue(history);
            }

            return historyQueue;
        }

        public static void AddUser(string name, string email, string password, string role)
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                INSERT INTO Users
                (
                    Name,
                    Email,
                    Password,
                    Role
                )
                VALUES
                (
                    @name,
                    @email,
                    @password,
                    @role
                )";

                using var cmd =
                    new SqliteCommand(query, db);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<UserClass> GetAgents()
        {
            List<UserClass> agents = new List<UserClass>();

            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = @"
                SELECT Id, Name
                FROM Users
                WHERE Role = 'Tecnico'
                OR Role = 'Admin'";

                using var cmd = new SqliteCommand(query, db);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UserClass user = new UserClass();

                    user.Id = Convert.ToInt32(reader["Id"]);

                    user.Name = reader["Name"].ToString();

                    agents.Add(user);
                }
            }

            return agents;
        }
    }

}
