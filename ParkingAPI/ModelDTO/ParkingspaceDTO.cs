namespace ParkingAPI.ModelDTO
{
    public class ParkingspaceDTO
    {
        public int ParkingspaceId { get; set; }
        public int ParkinglotId { get; set; }
        public bool Status { get; set; }
        public int SpaceNumber { get; set; }
        public ParkingspaceDTO()
        {

        }
    }
}
