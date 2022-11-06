using ParkingAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingAPI.ModelDTO;
using ParkingAPI.DBConnection;
using ParkingAPI.DAO;
using Newtonsoft.Json;
using NuGet.Protocol;
namespace ParkingAPI.Service
{
    [Route("api/[Controller]")]
    [ApiController]

    public class ParkingspaceController : ControllerBase
    {
        [HttpGet]
        [Route("{parkingspaceId}")]
        public ActionResult<ParkingspaceDTO>GetParkingspaceById(int parkingspaceId)
        {
            ParkingspaceDAO psDAO = DAOFactory.ParkingspaceConnection();
            ParkingspaceDTO parkingspace = psDAO.GetParkingspaceById(parkingspaceId);
            if (psDAO != null)
            {
                return Ok(parkingspace.ToJson());
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult CreateParkingspace(ParkingspaceDTO parkingspaceDTO)
        {
            if(parkingspaceDTO != null)
            {
                ParkingspaceDAO psDAO = DAOFactory.ParkingspaceConnection();
                psDAO.CreateParkingspace(parkingspaceDTO);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{ParkingspaceId}")]
        public ActionResult DeleteParking(int parkingspaceId)
        {
            ParkingspaceDAO parkingspaceDAO = DAOFactory.ParkingspaceConnection();
            if(parkingspaceDAO.DeleteParkingspace(parkingspaceId))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
