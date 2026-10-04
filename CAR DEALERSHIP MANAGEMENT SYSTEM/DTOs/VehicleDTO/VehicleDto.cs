namespace CAR_DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTO
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public int CategoryId { get; set; }
    }
}
