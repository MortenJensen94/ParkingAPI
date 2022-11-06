using System.Data.SqlClient;
using Npgsql;
using ParkingAPI.DAO;

namespace ParkingAPI.DBConnection
{
    public class DAOFactory
    {
        
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(
                @"Server=localhost;Port=5432;User Id=postgres;Password=08061994;Database=SensadeProject");
        }
        public static ParkingareaDAO ParkingareaConnection()
        {
            return new ParkingareaDAO(GetConnection());
        }
        public static ParkingspaceDAO ParkingspaceConnection()
        {
            return new ParkingspaceDAO(GetConnection());
        }
    }
}
