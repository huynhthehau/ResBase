using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManager.Domain.Entities

{
    public class Restaurant : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ref { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Domain { get; set; } = null!;
    }
}
