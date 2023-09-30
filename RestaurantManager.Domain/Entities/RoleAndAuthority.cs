using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class RoleAndAuthority : BaseEntity
    {
        public Guid RoleId { get; set; }
        public Guid AuthorityId { get; set; }
    }
}