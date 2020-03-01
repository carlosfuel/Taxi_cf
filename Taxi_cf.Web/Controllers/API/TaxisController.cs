using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Taxi_cf.Web.Data;
using Taxi_cf.Web.Data.Entities;
using Taxi_cf.Web.Helpers;

namespace Taxi_cf.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxisController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConverterHelper _converterHelper;

        public TaxisController(
            DataContext context,
            IConverterHelper converterHelper)
        {
            _context = context;
            _converterHelper = converterHelper;
        }

        // GET: api/Taxis/5
        [HttpGet("{placa}")]
        public async Task<IActionResult> GetTaxiEntity([FromRoute] string placa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            placa = placa.ToUpper();
            TaxiEntity taxiEntity = await _context.Taxis
                .Include(t => t.User)         //USUARIO CONDUCTOR
                .Include(t => t.Trips)         //VIAJES
                .ThenInclude(t => t.TripDetails) //DETALLE DE LOS VIAJES
                .Include(t => t.Trips)
                .ThenInclude(t => t.User)      //USUARIO PASAJERO
                .FirstOrDefaultAsync(t => t.Plaque == placa);

            if (taxiEntity == null)
            {
                return NotFound();
            }

            return Ok(_converterHelper.ToTaxiResponse(taxiEntity));
        }
    }
}