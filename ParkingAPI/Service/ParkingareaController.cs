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
    public class ParkingareaController : ControllerBase
    {
        [HttpGet]
        [Route("{parkingareaId}")]
        public ActionResult<ParkingareaDTO> GetParkingareaById(int parkingareaId)
        {
            ParkingareaDAO plDTO = DAOFactory.ParkingareaConnection();
           ParkingareaDTO result = plDTO.GetParkingareaById(parkingareaId);
            if (plDTO != null)
            {
                return Ok(result.ToJson());
            }
            return NotFound();
        }
        [HttpPost]

        public ActionResult CreateParkingarea(ParkingareaDTO parkingareaDTO)
        {
            if (parkingareaDTO != null)
            {
                ParkingareaDAO paDAO = DAOFactory.ParkingareaConnection();
                paDAO.CreateParkingarea(parkingareaDTO);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{ParkingareaId}")]

        public ActionResult DeleteParking(int parkingareaId)
        {
            ParkingareaDAO parkingareaDAO = DAOFactory.ParkingareaConnection();
            if(parkingareaDAO.DeleteParkingarea(parkingareaId))
                {
                return Ok();
            }
            return NotFound();
        }

    }
}
