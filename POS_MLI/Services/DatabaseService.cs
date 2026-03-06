using Npgsql;
using System.Data;


namespace POS_MLI.Services
{
    class DatabaseService
    {
        private string connectionString = "Host=191.111.5.3;Port=5432;Username=postgres;Password=p@ssw0rd;Database=pgpos_xy";
        public DataTable Query(string sql)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
    }
}
