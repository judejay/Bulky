using System.ComponentModel.DataAnnotations;

namespace BulkyWeb_Razor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a category name.")]
        [Display(Name = "Category Name")]
        [MaxLength(255)]
        public required string Name { get; set; }
        [Display(Name = "Display Order")]
        [Required(ErrorMessage = "Please enter a display order.")]
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100.")]
        public int DisplayOrder { get; set; }
    }
}
