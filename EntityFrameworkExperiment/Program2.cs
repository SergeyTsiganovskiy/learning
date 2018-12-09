using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.PostgreSql;
using EntityFrameworkExperiment.entity;
using EntityFrameworkExperiment.Properties;

using Npgsql;

namespace EntityFrameworkExperiment
{
    public class EntityFrameworkExperiment2
    {
        public static void Main()
        {
            using (StreamWriter writer = new StreamWriter("E:\\invoice100000.txt", true))
            {
                writer.WriteLine("Carrier|Fill Date|NDC 11|Product Name|Drug Strength|Qty|#Rxs|Days Sply|Pharmacy#|Cardholder #|Rx#|MD DEA#|REFILL|Physician NPI|Pharmacy NPI|Dosage Form");
                for (int i = 0; i < 100000; i++)
                {
                    writer.WriteLine($"PRMR|20160109|3762000000{i}|REPATHA PUSHTRONEX SYSTEM|420.0|3|1|30|6|9MY14320201|6244669|AK2499780|0|1225008329|1109970664|SO");
                }

            }


            //    var customers = CustomerRepository.GetCustomers();
            //    var customersUnique = CustomerRepository.GetCustomersID(12345);


            //    customers.ToList().ForEach(customer => Console.WriteLine(customer.id  + " " + customer.name));
            //    Console.ReadLine();
            //}


            //private static List<Сustomer> GetCustomers()
            //{
            //    var context = new mc_customers_amgen_context();
            //    var customers = context.Сustomer.ToList();
            //    return customers;
            //}

            //private static Сustomer GetCustomersBQueary(string id)
            //{
            //    var context = new mc_customers_amgen_context();
            //    return context.Сustomer.All(x=>x.id.Equals(id)).ToList().FirstOrDefault();
            //}

            //private static Сustomer GetCustomersById(string id)
            //{
            //    var context = new mc_customers_amgen_context();
            //    return context.Сustomer.Where(x => x.id.Equals(id)).ToList().FirstOrDefault();
            //}

            //int id;
            //List<string> custlist = new List<string>();
            //using (DbConnection connection = new DbConnectio(ConfigurationManager["QA2"].ConnectionString, ConfigurationManager["AmgenCustomers"]))
            //{
            //    CustomerRepository custr = new CustomerRepository(connection);
            //    id = custr.GetCustomerIdByName("knvkjsnfjenbjn");
            //    custlist = custr.GetAllCustWithNameStartingFrom("2018");

            //}

            //int id1;
            //List<string> contrlist = new List<string>();
            //using (DbConnection connection = new DbConnectio(ConfigurationManager["QA2"].ConnectionString, ConfigurationManager["AmgenContracts"]))
            //{
            //    ContractRepository contr = new ContractRepository(connection);
            //    id1 = contr.GetContractByName("knvkjsnfjenbjn");
            //    contrlist = contr.GetAllContrWithCreatingYearMoreThan("2018");
            //}
        }
    }

    class CustomerRepository
    {
        private DbConnection connection;
        public CustomerRepository(DbConnection connection)
        {
            this.connection = connection;
        }

        public int GetCustomerIdByName()
        {
            // DataTable logic
            return 1;
        }
    }
}