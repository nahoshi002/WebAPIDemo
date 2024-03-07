using System.ComponentModel.DataAnnotations;
using WebAPIDemo.Models.Validations;

namespace WebAPIDemo.Models
{
    public class Bike
    {
        [Required]
        public int BikeId { get; set; }

        [Required]  
        public int SupId { get; set; }

        [Required]
        public int TypeId { get; set; }

        public string? BikeName { get; set;}

        [Bike_EnsureCorrectPrice]
        public double? Price { get; set; }

        [Required]
        public string QrCode { get; set;}

        public String? BikeImg {  get; set;}

        [Required]        
        public int Status { get; set;}
    }
}
