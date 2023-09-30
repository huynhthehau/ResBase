using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Domain.Entities
{
    public class UserInformation
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid RestaurantId { get; set; }
        public Guid RoleId { get; set; }
    }
}