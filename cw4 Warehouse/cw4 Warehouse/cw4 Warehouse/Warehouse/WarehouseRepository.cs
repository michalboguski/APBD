using System.Data.SqlClient;

namespace cw4;

public class WarehouseRepository : IWarehouseRepository
{
    private IConfiguration _configuration;
    public WarehouseRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public WarehouseDTO GetWarehouseById(long warehouseId)
    {
        var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.OpenAsync();
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * FROM Warehouse where IdWarehouse = @warehouseId";
        cmd.Parameters.AddWithValue("@warehouseId", warehouseId);

        var dr = cmd.ExecuteReader();

        if (!dr.Read()) return null;

        return new WarehouseDTO
        {
            IdWarehouse = (long)dr["IdWarehouse"],
            name = dr["Name"].ToString(),
            address = dr["Address"].ToString()
        };
    }
}