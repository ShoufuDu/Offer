using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Offer.Models;

namespace Offer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EOfferController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateOffer([FromBody]EOffer offer)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
