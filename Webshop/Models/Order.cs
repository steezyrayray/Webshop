using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Address Address { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public DateTime Created {  get; set; } = DateTime.Now;
    }
}
