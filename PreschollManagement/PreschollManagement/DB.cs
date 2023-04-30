using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PreschollManagement
{
    class DB
    {
        private static string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyMamNon;Integrated Security=True";

        private DB() { }

        private static DB instance;

        public static DB Instance 
        {
            get 
            {
                if (instance == null) {
                    instance = new DB();
                }
                return instance;
            }
        }

        public SqlConnection getConnection() 
        {
            return new SqlConnection(connection);
        }
    }
}
