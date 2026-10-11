
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice.Models
{
    [Table("CategoryTbl")]
    public class CategoryModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }

        public string? categoryName { get; set; }

        public string? categoryLogo { get; set; }
    }
}
