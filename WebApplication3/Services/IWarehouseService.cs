using WebApplication3.Model;

namespace WebApplication3.Services;

public interface IWarehouseService
{
    public Task<int> AddGoods(WarehouseDTO warehouseDTO);
}