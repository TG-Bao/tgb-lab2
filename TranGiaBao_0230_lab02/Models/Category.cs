using System.ComponentModel.DataAnnotations;

namespace TranGiaBao_0230_lab02.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
