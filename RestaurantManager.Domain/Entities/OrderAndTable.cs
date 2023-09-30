using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class OrderAndTable : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid TableId { get; set; }
    }
}