using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class MenuItem : BaseEntity
    {
        public int Ref { get; set; }
        public string ItemName { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public bool Status { get; set; }
    }
}