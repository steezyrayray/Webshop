using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop.Models
{
    public class ArticleOrder
    {
        [Key]
        public int Id { get; set; }
        public virtual Article Article { get; set; }
        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
