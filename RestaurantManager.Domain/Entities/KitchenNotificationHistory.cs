using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class KitchenNotificationHistory : BaseEntity
    {
        public int Ref { get; set; }
        public DateTime NotifiedDate { get; set; }
        public Guid OrderId { get; set; }
    }
}