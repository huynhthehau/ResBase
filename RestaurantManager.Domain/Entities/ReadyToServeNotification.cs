using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class ReadyToServeNotification : BaseEntity
    {
        public bool IsComplete { get; set; }
        public Guid ItemAdditionNotificationId { get; set; }
        public DateTime NotifiedDate { get; set; }
        public int ServedQuantity { get; set; }
    }
}