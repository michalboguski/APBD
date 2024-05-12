using System.Xml.Linq;

namespace cw4;

public interface IWarehouseRepository
{
   public WarehouseDTO GetWarehouseById(long warehouseId);
   
}

