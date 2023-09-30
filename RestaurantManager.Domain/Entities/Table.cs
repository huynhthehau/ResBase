using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class Table : BaseEntity
    {
        public Guid RestaurantId { get; set; }
        public int NumberOfSeat { get; set; }
        public string Zone { get; set; }
        public bool Status { get; set; }
    }
}