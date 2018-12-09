using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExperiment.Properties;

using Npgsql;

namespace EntityFrameworkExperiment
{
    public class EntityFrameworkExperiment
    {
        public static void Main31()
        {
            using (IDbConnection connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["AmgenCustomers"].ConnectionString))
            {
                IDbCommand command = new NpgsqlCommand("SELECT customers.name FROM customers ");
                command.Connection = connection;

                connection.Open();
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
            }
            Console.ReadLine();
        }
    }
}
