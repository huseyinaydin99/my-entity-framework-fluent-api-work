using NorthwindEFFluentAPI.DAL.Entities;
using System.Collections.Generic;

namespace NorthwindEFFluentAPI
{
    //Fluent API'yi kullanarak Entity'lerimizi temiz tuttuk böylelikle daha clean code oldu. SOLID. DRY. (;
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }

        public string NameSurname { get; set; }

        public string Company { get; set; }

        public string City { get; set; }

        public string Counrty { get; set; }

        public byte[] Timestamp { get; set; }

        public List<Order> Orders { get; set; }
    }
}