
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using WebAPIDemo.Models.Repositories;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BikesController : ControllerBase
    {

        [HttpGet]
        public String GetBikes()
        {
            return "Trả về tất cả các xe";
        }

        [HttpGet("{id}")]
        public IActionResult GetBikeByID(int id)
        {
            if(id < 1)
            {
                return BadRequest();
            }
            var Bike = BikeRepository.GetBikeById(id);
            if(Bike == null)
            {
                return NotFound();
            }
            return Ok(Bike);
        }

        [HttpPost]
        public String CreatingBike([FromForm] Bike bike)
        {
            return $"Thêm mới thông tin của xe";
        }

        [HttpPut("{id}")]
        public String UpdateBike(int id)
        {
            return $"Thay đổi thông tin của xe có id: {id}";
        }

        [HttpDelete("{id}")]
        public String DeleteBike(int id)
        {
            return $"Xóa thông tin của xe có id: {id}";
        }
    }
}
