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
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicles = await _unitOfWork.Makes.GetAll();
            return Ok(vehicles);

        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
      
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.ID == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Vehicles.Update(vehicle);


            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
        

            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.ID }, vehicle);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.ID == id);

            if (_unitOfWork.Makes == null)
            {
                return NotFound();
            }

            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var vehicles = await _unitOfWork.Vehicles.Get(q => q.ID == id);
            return vehicles != null;
        }
    }
}
