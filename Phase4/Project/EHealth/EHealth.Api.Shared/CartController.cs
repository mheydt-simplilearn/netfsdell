using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHealth.Api.Shared
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public CartController()
        {

        }

        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Buy()
        {
            return Ok();
        }
    }
}
