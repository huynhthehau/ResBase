using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class ItemCancellationNotification : BaseEntity
    {
        public int Quantity { get; set; }
        public Guid ItemAdditionNotificationId { get; set; }
        public Guid KitchenNotificationHistoryId { get; set; }
        public Guid OrderDetailId { get; set; }
        public string CancellationNote { get; set; }
        public string CancellationReason { get; set; }
    }
}