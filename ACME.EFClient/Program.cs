using ACME.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ACME.EFClient
{
    class Program
    {
        private static string connectionString = "";

        static void Main(string[] args)
        {
            ReadCustomers();
            Console.WriteLine("Done!");
        }

        private static void ReadCustomers()
        {
            var bld = new DbContextOptionsBuilder<BPProductsContext>();
            bld.UseSqlServer(connectionString);
            var context = new BPProductsContext(bld.Options);

            var query = context.Customers.Take(100);

            foreach(var customer in query)
            {
                Console.WriteLine($"[{customer.Id}] {customer.Firstname} {customer.Lastname}");
            }

        }
    }
}
