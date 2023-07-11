using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApplication.Server.Data;
using CarRentalApplication.Shared.Domain;
using CarRentalApplication.Server.IRepository;

namespace CarRentalApplication.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookings = await _unitOfWork.Bookings.GetAll();
            return Ok(bookings);

        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
      
            var booking = await _unitOfWork.Bookings.Get(q => q.ID == id);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);


            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
        

            await _unitOfWork.Bookings.Insert(booking);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.ID }, booking);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.Makes.Get(q => q.ID == id);

            if (_unitOfWork.Makes == null)
            {
                return NotFound();
            }

            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var makes = await _unitOfWork.Makes.Get(q => q.ID == id);
            return makes != null;
        }
    }
}
