namespace ParkingAPI.Model
{
    public class Parkingspace
    {
        public int ParkingspaceId { get; set; }
        public int ParkingAreaId { get; set; }
        public bool Status { get; set; }
        public int SpaceNumber { get; set; }
        public Parkingspace(int parkingspaceId, int parkingAreaId, bool status, int spaceNumber)
        {
            ParkingspaceId = parkingspaceId;
            ParkingAreaId = parkingAreaId;
            Status = status;
            SpaceNumber = spaceNumber;
        }
        public Parkinglot Parkinglot { get; set; }
        public int ParkinglotId { get; set; }
    }
}
