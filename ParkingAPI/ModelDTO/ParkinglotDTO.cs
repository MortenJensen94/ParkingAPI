namespace ParkingAPI.ModelDTO
{
    public class ParkinglotDTO
    {
        public int ParkinglotId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }
        public ParkinglotDTO()
        {

        }
    }
}
