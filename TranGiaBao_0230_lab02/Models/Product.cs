using System.ComponentModel.DataAnnotations;

namespace TranGiaBao_0230_lab02.Models
{
    public class Product
    {
        [Display(Name = "Mã sản phẩm")]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        
        public string? ImageUrl { get; set; } // Đường dẫn đến hình ảnh đại diện
 public List<string>? ImageUrls { get; set; } // Danh sách các hình ảnh
    }
}
