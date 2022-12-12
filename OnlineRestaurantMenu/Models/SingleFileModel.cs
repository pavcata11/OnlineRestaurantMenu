using OnlineRestaurantMenu.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurantMenu.Models
{
    public class SingleFileModel : ReponseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Image { get; set; }
        public DrinkMainTypes DrinkMainType { get; set; }
        public int TypeId { get; set; }
        public IEnumerable<DrinkTypesModel> DrinkTypes { get; set; } = new List<DrinkTypesModel>();
        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; }
        [Required(ErrorMessage = "Please select file")]
        public IFormFile File { get; set; }
    }
    public class ReponseModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsResponse { get; set; }
    }
}
