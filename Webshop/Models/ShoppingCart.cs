using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Article Article { get; set; }
        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
    }
}
