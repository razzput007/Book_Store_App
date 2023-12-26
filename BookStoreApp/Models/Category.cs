using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BookStoreApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage="Name should be only Characters")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name should be between 5-20")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
