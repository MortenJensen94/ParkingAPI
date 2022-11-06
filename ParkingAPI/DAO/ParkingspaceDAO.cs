using Npgsql;
using ParkingAPI.ModelDTO;
using Dapper;

namespace ParkingAPI.DAO
{
    public class ParkingspaceDAO
    {
        private readonly NpgsqlConnection _connection;
        public ParkingspaceDAO(NpgsqlConnection _connection)
        {
            this._connection = _connection;
        }
        public ParkingspaceDTO GetParkingspaceById(int parkingspaceId)
        {
            ParkingspaceDTO psDTO;
            string sql = "SELECT ParkingspaceId, ParkingareaId, Status, SpaceNumber parkingareaId FROM Parking_space WHERE ParkingspaceId = @ParkingspaceId";
            var param = new {ParkingspaceId = parkingspaceId};
            using (_connection)
            {
                psDTO = _connection.QuerySingle<ParkingspaceDTO>(sql, param);
            }
            return psDTO;
        }
        public int CreateParkingspace(ParkingspaceDTO parkingspaceDTO)
        {
            int psDTO;
            string sql = "INSERT INTO Parking_space VALUES (@ParkingspaceId,@Parkingspacestatus,@spacenumber,@parkingareaid)";
            var param = new
            {
                ParkingspaceId = parkingspaceDTO.ParkingspaceId,
                ParkingspaceStatus = parkingspaceDTO.ParkingspaceStatus,
                SpaceNumber = parkingspaceDTO.SpaceNumber,
                ParkingareaId = parkingspaceDTO.ParkingsareaId,
            };
            using (_connection)
            {
                psDTO = _connection.Execute(sql, param);
            }
            return psDTO;
        }
        public bool DeleteParkingspace(int parkingspaceId)
        {
            bool result = false;
            string sql = "DELETE FROM Parking_space WHERE ParkingspaceId = @ParkingspaceId";
            var param = new { ParkingspaceId = parkingspaceId };
            using (_connection)
            {
                _connection.Execute(sql, param);
                if (_connection.Execute(sql, param) == 1)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
