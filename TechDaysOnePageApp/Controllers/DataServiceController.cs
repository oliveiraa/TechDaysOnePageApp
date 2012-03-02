using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechDaysOnePageApp.Models;
using System.Web.Http.Data.EntityFramework;

namespace TechDaysOnePageApp.Controllers
{
    public class DataServiceController : DbDataController<AppDbContext>
    {
        public void InsertDelivery(Delivery delivery) { InsertEntity(delivery); }
        public void UpdateDelivery(Delivery delivery) { UpdateEntity(delivery); }
        public void DeleteDelivery(Delivery delivery) { DeleteEntity(delivery); }
        
        
        public IQueryable<Delivery> GetDeliveriesForToday()
        {
            return DbContext.Deliveries.Include("Customer").OrderBy(x => x.DeliveryId);
        }
    }
}
