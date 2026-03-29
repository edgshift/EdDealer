namespace EdDealerAPI.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Brand { get; set; } 
        public string Model { get; set; }
        public string Vin { get; set; }
    }
}
