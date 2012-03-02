using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TechDaysOnePageApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

    }

    public class AppDataInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { CustomerId = 1, Address = "Address 1", Name = "Customer 1" },
                new Customer { CustomerId = 2, Address = "Address 2", Name = "Customer 2" },
                new Customer { CustomerId = 3, Address = "Address 3", Name = "Customer 3" },
                new Customer { CustomerId = 4, Address = "Address 4", Name = "Customer 4" }
            };

            customers.ForEach(x => context.Customers.Add(x));
            context.SaveChanges();

            var deliveries = new List<Delivery>
            {
                new Delivery { DeliveryId = 1, CustomerId = 1, Description = "Delivery to Customer 1", IsDelivered = false },
                new Delivery { DeliveryId = 2, CustomerId = 2, Description = "Delivery to Customer 2", IsDelivered = false },
                new Delivery { DeliveryId = 3, CustomerId = 3, Description = "Delivery to Customer 3", IsDelivered = false },
                new Delivery { DeliveryId = 4, CustomerId = 4, Description = "Delivery to Customer 4", IsDelivered = false },
                new Delivery { DeliveryId = 5, CustomerId = 1, Description = "Second Delivery to Customer 1", IsDelivered = false }
            };

            deliveries.ForEach(x => context.Deliveries.Add(x));
            context.SaveChanges();
        }
    }
}