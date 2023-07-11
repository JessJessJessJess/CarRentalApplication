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
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _unitOfWork.Customers.GetAll();
            return Ok(customers);

        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
      
            var customer = await _unitOfWork.Customers.Get(q => q.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Customers.Update(customer);


            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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
        public async Task<ActionResult<Make>> PostCustomer(Customer customer)
        {
        

            await _unitOfWork.Customers.Insert(customer);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetCustomer", new { id = customer.ID }, customer);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletCustomer(int id)
        {
            var make = await _unitOfWork.Customers.Get(q => q.ID == id);

            if (_unitOfWork.Makes == null)
            {
                return NotFound();
            }

            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var customers = await _unitOfWork.Customers.Get(q => q.ID == id);
            return customers != null;
        }
    }
}
