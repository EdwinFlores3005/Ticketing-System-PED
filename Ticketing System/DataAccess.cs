using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System
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
                FOREIGN KEY (TicketId) REFERENCES Tickets(Id)
            );";

                var createHistory = new SqliteCommand(historyTable, db);
                createHistory.ExecuteNonQuery();
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
        INSERT INTO Tickets (Title, Description, Status, CreatedAt, Priority, CreatedByUserId)
        VALUES (@title, @description, @status, @createdAt, @priority, @userId);";

                using var insertCmd = new SqliteCommand(insertQuery, db);

                insertCmd.Parameters.AddWithValue("@title", title);
                insertCmd.Parameters.AddWithValue("@description", description);
                insertCmd.Parameters.AddWithValue("@status", "New");
                insertCmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                insertCmd.Parameters.AddWithValue("@priority", priority);
                insertCmd.Parameters.AddWithValue("@userId", userId);

                insertCmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetTickets()
        {
            using (var db = new SqliteConnection("Data Source=TicketSystem.db"))
            {
                db.Open();

                string query = "SELECT Id, Title, Description FROM Tickets";

                using var command = new SqliteCommand(query, db);
                using var reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                return table;
            }
        }
    }

}
