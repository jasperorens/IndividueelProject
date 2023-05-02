using System;

namespace ClassLibTeam00.Data.Framework
{
    static class Settings
    {
        public static string GetConnectionString()
        {
            String connectionString = "Trusted_Connection = True;";

            connectionString += $@"Server=DESKTOP-26A9125\SQLEXPRESS;";
            connectionString += $"Database=DB_Team10;";
            return connectionString;
        }
    }
}
