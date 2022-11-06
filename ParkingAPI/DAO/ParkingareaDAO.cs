using Npgsql;
using ParkingAPI.ModelDTO;
using Dapper;

namespace ParkingAPI.DAO
{
    public class ParkingareaDAO
    {
        private readonly NpgsqlConnection _connection;
        public ParkingareaDAO(NpgsqlConnection _connection)
        {
            this._connection = _connection;
        }
        public ParkingareaDTO GetParkingareaById(int parkingareaId)
        {
            ParkingareaDTO plDTO;
            string sql = "SELECT ParkingareaId, Streetarea,City,ZipCode,Latitude,Longitude FROM Parking_area WHERE ParkingareaId = @ParkingareaId";
            var param = new { ParkingareaId = parkingareaId };
            using (_connection)
            {
                plDTO = _connection.QuerySingle<ParkingareaDTO>(sql, param);
            }
            return plDTO;
        }
        public int CreateParkingarea(ParkingareaDTO parkingareaDTO)
        {
            int plDTO;

            string sql = "INSERT INTO Parking_area VALUES (@ParkingareaId,@StreetAddress,@City,@ZipCode,@Latitude,@Longitude)";
            var param = new
            {
                ParkingareaId = parkingareaDTO.ParkingareaId,
                StreetAddress = parkingareaDTO.StreetArea,
                City = parkingareaDTO.City,
                ZipCode = parkingareaDTO.ZipCode,
                Latitude = parkingareaDTO.Latitude,
                Longitude = parkingareaDTO.Longitude,
            };
            using(_connection)
            {
                plDTO = _connection.Execute(sql, param);
            }
            return plDTO;
        }
        public bool DeleteParkingarea(int parkingareaId)
        {
            bool result = false;
            string sql = "DELETE FROM Parking_area WHERE ParkingareaId = @ParkingareaId";
            var param = new {ParkingareaId = parkingareaId};
            using(_connection)
            {
                _connection.Execute(sql, param);
            }
            return result;
        }

    }
}
