using Abo.Model;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Abo.Infrastructure
{
    public class ABOMethods : IABOmethods
    {
        private readonly string _connectionString = "Data Source=contactdata.db";

        public ABOMethods(string connectionString) { 
            _connectionString = connectionString;
            using (var connection = new SQLite.SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "IF OBJECT_ID('Contacts', 'U') IS NULL CREATE TABLE Contacts (Name TEXT NOT NULL PRIMARY KEY, Email TEXT, Phone TEXT, BirthDate TEXT)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public ABOMethods() { 
            using (var connection = new SQLite.SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "IF OBJECT_ID('Contacts', 'U') IS NULL CREATE TABLE Contacts (Name TEXT NOT NULL PRIMARY KEY, Email TEXT, Phone TEXT, BirthDate TEXT)";
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Add(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string name)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public Contact Get(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}