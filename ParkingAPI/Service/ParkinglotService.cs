using ParkingAPI.Model;

namespace ParkingAPI.Service
{
    public class ParkinglotService
    {
        private readonly HttpClient _httpClient;
        private static readonly string restUrl = "";

        public ParkinglotService()
        {
            _httpClient = new HttpClient();
        }
    }
}
