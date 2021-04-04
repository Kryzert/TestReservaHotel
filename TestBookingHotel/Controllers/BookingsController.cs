using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservasHotel.Data;
using ReservasHotel.Models;

namespace ReservasHotel.Controllers
{
    [ApiController]
    [Route("v1/bookings")]
    
    public class BookingController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Bookings>>> Get([FromServices] DataContext context)
        {
            var bookings = await context.Bookings.ToListAsync();
            return bookings;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Bookings>> Post(
            [FromServices] DataContext context,
            [FromBody] Bookings model)
        {
            if (ModelState.IsValid)
            {
                context.Bookings.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}