using System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Models.Validations
{
    public class Bike_EnsureCorrectPriceAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bike = validationContext.ObjectInstance as Bike;

            if(bike != null)
            {
                if(!String.IsNullOrWhiteSpace(bike.QrCode) && bike.Price == null)
                {
                    return new ValidationResult("Hãy thêm giá thuê vào xe!");
                }else if(String.IsNullOrWhiteSpace(bike.QrCode) && bike.Price != 0){
                    return new ValidationResult("Xe đã làm gì có mã qrcode mà thêm giá!");
                }
            }
            return ValidationResult.Success;
        }
    }
}
