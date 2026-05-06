using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên Danh Mục không được để trống")]
        public string Name { get; set; }
    }
}
