namespace ParkingAPI.ModelDTO
{
    public class ParkingareaDTO
    {
        public int ParkingareaId { get; set; }
        public string StreetArea { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }
        public ParkingareaDTO()
        {

        }
    }
}
