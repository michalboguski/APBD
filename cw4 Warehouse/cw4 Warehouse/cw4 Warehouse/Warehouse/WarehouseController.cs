using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    [Route("/warehouse")]
    internal class WarehouseController : ControllerBase
    {
        long productId { get; set; }
        long warehouseId { get; set; }
        int amount { get; set; }
        DateTime createdAt { get; set; }


    }




}
