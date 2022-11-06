namespace ParkingAPI.ModelDTO
{
    public class ParkingspaceDTO
    {
        public int ParkingspaceId { get; set; }
        public bool ParkingspaceStatus { get; set; }
        public int SpaceNumber { get; set; }
        public int ParkingsareaId { get; set; }

        public ParkingspaceDTO()
        {

        }
    }
}
