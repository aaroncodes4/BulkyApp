using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name of Category")]
        public string Name { get; set; }
        [DisplayName("Number of Categories")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
