using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Offer.Models;

namespace Offer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostcodesController : ControllerBase
    {
        private OfferContext context;

        public PostcodesController(OfferContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        IActionResult GetPostcodes()
        {
            IQueryable<Postcode> postcodes = context.Postcodes;

            return Ok(postcodes.ToList());
        }
    }
}