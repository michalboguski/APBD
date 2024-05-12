namespace cw4;

public class WarehouseService : IWarehouseService
{
    private IWarehouseRepository _warehouseRepository;

    public WarehouseService(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }

    public bool saveNewItem(ProductOrderInWarehouseDTO powDTO)
    {
        throw new NotImplementedException();
    }

    public Boolean IsWarehouseExist(long warehouseId)
    {
        var w = _warehouseRepository.GetWarehouseById(warehouseId);
            if (w != null)
            {
                return true;
            }

            return false;
    }
}