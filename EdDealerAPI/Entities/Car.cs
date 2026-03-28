namespace EdDealerAPI.Entities
{
    public class Car
    {
        public required int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
    }
}
