namespace ParkingAPI.Model
{
    public class Parkinglot
    {
        public int Id {get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }

        public Parkinglot(int id, string streetAddress, string city, int zipCode, decimal latitude, decimal longitude)
        {
            Id = id;
            StreetAddress = streetAddress;
            City = city;
            ZipCode = zipCode;
            Latitude = latitude;
            Longitude = longitude;
        }
        public virtual List<Parkingspace> Parkingspaces { get; set; }
    }
}
