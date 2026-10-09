using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice.Models
{
    [Table("productMaster")]
  public class productModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        public int catId { get; set; }
        public string? productName { get; set; }
        public string? shortName { get; set; }
        public float price { get; set; }
        public string? description { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeOnly modifiedDate { get; set; }
    }
}
