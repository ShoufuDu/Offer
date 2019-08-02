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
    public class CountriesController : ControllerBase
    {
        private OfferContext context;

        public CountriesController(OfferContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            IQueryable<Country> countries = context.Countries;

            return Ok(countries.ToList());
        }
    }
}