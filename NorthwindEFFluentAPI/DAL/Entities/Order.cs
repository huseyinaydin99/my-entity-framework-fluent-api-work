using System;
using NorthwindEFFluentAPI.DAL.Entities;

namespace NorthwindEFFluentAPI
{
    //Fluent API'yi kullanarak Entity'lerimizi temiz tuttuk böylelikle daha clean code oldu. SOLID. DRY. (;
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
    }
}