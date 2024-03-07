namespace WebAPIDemo.Models.Repositories
{
    public class BikeRepository
    {
        private static List<Bike> bikes = new List<Bike>()
        {
            new Bike {BikeId = 1, SupId = 2, TypeId = 3, BikeName = "Xe đạp ateo", Price = 2, QrCode = "sdsad", Status = 5},
            new Bike {BikeId = 2, SupId = 3, TypeId = 3, BikeName = "Xe đạp ateo2", Price = 2, QrCode = "sdsadb", Status = 4},
            new Bike {BikeId = 3, SupId = 4, TypeId = 5, BikeName = "Xe đạp ateo3", Price = 2, QrCode = "sdsada", Status = 3},
        };

        public static bool BikeExist(int id)
        {
            return bikes.Any(x => x.BikeId == id);
        }

        public static Bike GetBikeById(int id)
        {
            return bikes.FirstOrDefault(x => x.BikeId == id);
        }
    }
}
