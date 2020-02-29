using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Taxi_cf.Web.Data;
using Taxi_cf.Web.Data.Entities;

namespace Taxi_cf.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxisController : ControllerBase
    {
        private readonly DataContext _context;

        public TaxisController(DataContext context)
        {
            _context = context;
        }
        
        // GET: api/Taxis/5
        [HttpGet("{placa}")]
        public async Task<IActionResult> GetTaxiEntity([FromRoute] string placa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TaxiEntity taxiEntity = 
                await _context.Taxis.FirstOrDefaultAsync(t => t.Plaque ==  placa); // no funciona con valores enteros

            if (taxiEntity == null)
            {
                return NotFound();
            }

            return Ok(taxiEntity);
        }
    }
}