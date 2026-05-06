using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        [Required(ErrorMessage = "Giá không được để trống")]
        public decimal Price { get; set; }

        // Foreign key
        [Required(ErrorMessage = "Phải chọn Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
