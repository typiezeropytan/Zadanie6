using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
using WebApplication3.Services;

namespace WebApplication3.Controller;

[ApiController]
[Route("api/[controller]")]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;

    public WarehouseController(IWarehouseService warehouseService)
    {
        _warehouseService = warehouseService;
    }

    [HttpPost]
    public Task<IActionResult> AllGoods(WarehouseDTO wareHouseDto)
    {
        try
        {
            return Task.FromResult<IActionResult>(Ok($"Product has been added with id = {{await _warehouseService.AddGoods(WareHouse)}}"));
        }
        catch (Exception e)
        {
            return Task.FromResult<IActionResult>(NotFound(e.StackTrace));
        }
    }
}