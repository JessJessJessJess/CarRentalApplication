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
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var colors = await _unitOfWork.Customers.GetAll();
            return Ok(colors);

        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColors(int id)
        {
      
            var color = await _unitOfWork.Colors.Get(q => q.ID == id);

            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color color)
        {
            if (id != color.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(color);


            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorExists(id))
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
        public async Task<ActionResult<Color>> PostColor(Color color)
        {
        

            await _unitOfWork.Colors.Insert(color);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetColor", new { id = color.ID }, color);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.ID == id);

            if (_unitOfWork.Colors == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            var colors = await _unitOfWork.Colors.Get(q => q.ID == id);
            return colors != null;
        }
    }
}
