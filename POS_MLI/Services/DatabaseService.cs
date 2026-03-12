using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Npgsql;
using POS_MLI.Models;

namespace POS_MLI.Services
{
    public static class DatabaseService
    {
        private static string connectionString;

        public static bool Connect(DbConfig config)
        {
            try
            {
                connectionString =
                    $"Host={config.Host};" +
                    $"Port={config.Port};" +
                    $"Username={config.Username};" +
                    $"Password={config.Password};" +
                    $"Database={config.Database};" +
                    $"Pooling=true;" +
                    $"Timeout=5;" +
                    $"CommandTimeout=30;";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    conn.Close();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Database not connected. Call Connect() first.");

            return new NpgsqlConnection(connectionString);
        }

        public static List<T> Query<T>(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<T>(sql, param).ToList();
            }
        }

        public static T QueryFirst<T>(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.QueryFirstOrDefault<T>(sql, param);
            }
        }

        public static int Execute(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Execute(sql, param);
            }
        }
    }
}