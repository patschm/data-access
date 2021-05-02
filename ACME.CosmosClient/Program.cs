using System;
using System.Linq;
using ACME.Documents;
using Microsoft.Azure.Cosmos;


namespace ACME.CosmosClientX
{
    class Program
    {
        private static string endpoint = "";
        private static string key = "";

        static void Main(string[] args)
        {
            ReadCustomers();
            Console.WriteLine("Done!");
        }

        private static void ReadCustomers()
        {
            var client = new CosmosClient(endpoint, key);
            var custOrders = client.GetDatabase("ACME").GetContainer("CustomerOrders");
            var query = custOrders.GetItemLinqQueryable<Customer>(allowSynchronousQueryExecution:true).Take(100);

            foreach(var customer in query)
            {
                Console.WriteLine($"[{customer.Id}] {customer.Firstname} {customer.Lastname}");
            }


        }
    }
}
