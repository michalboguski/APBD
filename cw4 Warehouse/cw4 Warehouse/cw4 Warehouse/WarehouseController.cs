using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    [ApiController]
    [Route("/warehouses")]
    internal class WarehouseController : ControllerBase
    {
        private IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToWarehouse(ProductOrderInWarehouseDTO powDTO)
        {
            Boolean succes = _warehouseService.saveNewItem(powDTO);
            return Ok();
        }
    }
}