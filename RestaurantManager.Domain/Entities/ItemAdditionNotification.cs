using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class ItemAdditionNotification : BaseEntity
    {
        public bool IsComplete { get; set; }
        public bool IsPriority { get; set; }
        public string Note { get; set; }
        public int Quantity { get; set; }
        public Guid KitchenNotificationHistoryId { get; set; }
        public Guid OrderDetailId { get; set; }
    }
}