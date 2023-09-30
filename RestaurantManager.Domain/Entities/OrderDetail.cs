using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class OrderDetail : BaseEntity
    {
        public double Quantity { get; set; }
        public Guid OrderId { get; set; }
        public Guid MenuItemId { get; set; }
        public bool IsPriority { get; set; }
        public string Note { get; set; }
        public int UnnotifiedQuantity { get; set; }
        public int ServedQuantity { get; set; }

    }
}