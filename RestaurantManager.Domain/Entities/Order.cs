using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManager.Domain.Entities
{
    public class Order : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ref { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PayDate { get; set; }
        public bool IsTakeAway { get; set; }
        public bool IsPayByCash { get; set; }
        public Guid BankAccountInfoId { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }
    }
}