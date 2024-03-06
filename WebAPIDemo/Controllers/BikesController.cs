
using Microsoft.AspNetCore.Mvc;

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
        public String GetBikeByID(int id)
        {
            return $"Trả về xe có id: {id}";
        }

        [HttpPost]
        public String CreatingBike()
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
