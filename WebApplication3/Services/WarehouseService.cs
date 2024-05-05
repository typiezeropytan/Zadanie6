using WebApplication3.Model;
using WebApplication3.Repositories;

namespace WebApplication3.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;

    public WarehouseService(IWarehouseRepository repository)
    {
        _warehouseRepository = repository;
    }

    public async Task<int> AddGoods(WarehouseDTO wareHouseDTO)
    {
        (int idProduct, int idWarehouse, int amount, DateTime createdAt) = wareHouseDTO;

        if (!_warehouseRepository.DoesProductExist(idProduct).Result)
            throw new ArgumentException($"Product with id = {idProduct} does not exist!");
        
        if (!_warehouseRepository.DoesWarehouseExist(idWarehouse).Result)
            throw new ArgumentException($"Warehouse with id = {idProduct} does not exist!");
        
        if (!_warehouseRepository.DoesOrderExist(idProduct, amount, createdAt).Result)
            throw new ArgumentException($"Order with product id = {idProduct} " +
                                        $"in amount of = {amount} " +
                                        $"after {createdAt} does not exist!");

        int orderId = _warehouseRepository.GetOrderId(idProduct, amount, createdAt).Result;
        decimal price = _warehouseRepository.GetProductPrice(idProduct).Result;

        return await _warehouseRepository.AddGoods(idWarehouse, idProduct, orderId, amount, price * amount);
    }
}