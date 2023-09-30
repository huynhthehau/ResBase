using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class MenuItemAndCategory : BaseEntity
    {
        public Guid MenuItemId { get; set; }
        public Guid CategoryId { get; set; }
    }
}