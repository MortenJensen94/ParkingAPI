using System.Data.SqlClient;
using Npgsql;

namespace ParkingAPI.DBConnection
{
    public class DAOFactory
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(
                @"Server=localhost;Port=5432;User Id=prostgres;Password=08061994;Database=SensadeProject");
        }
    }
}
