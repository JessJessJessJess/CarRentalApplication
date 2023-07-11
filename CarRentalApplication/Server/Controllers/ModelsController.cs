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
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            if (_unitOfWork.Models == null)
            {
                return NotFound();
            }
            var models = await _unitOfWork.Models.GetAll();
            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            if (_unitOfWork == null)
            {
                return NotFound();
            }

            var models = await _unitOfWork.Models.GetAll(q => q.ID == id);

            if (models == null)
            {
                return NotFound();
            }

            return Ok(models);

        }

        [HttpPost]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Models.Update(model);

            try
            {
                await _unitOfWork.Save(this.HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
            if (_unitOfWork.Models == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Models' is null.");
            }

            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("Get Model", new { id = model.ID }, model);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.ID == id);
            if (_unitOfWork.Models == null)
            {
                return NotFound();
            }

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(this.HttpContext);

            if (model == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            var models = await _unitOfWork.Models.Get(q => q.ID == id);
            return models != null;

        }
    }
}

