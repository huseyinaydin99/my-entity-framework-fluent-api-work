using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindEFFluentAPI.DAL.Context;

namespace NorthwindEFFluentAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var northwindContext = new NorthwindContext())
            {
                foreach (var customer in northwindContext.Customers)
                {
                    Console.WriteLine(customer.ToString());
                }
            }

            Console.WriteLine("Kapanmasını istiyorsanız lütfen ekranın aşağısındaki klavyede görmüş olduğunuz herhangi bir tuşa nasıveriniz lütfen.");
            Console.ReadKey();
        }
    }
}