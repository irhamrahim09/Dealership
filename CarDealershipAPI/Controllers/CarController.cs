using Microsoft.AspNetCore.Mvc;
using CarDealershipAPI.Models;
using CarDealershipAPI.Services;

namespace CarDealershipAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetAll()
        {
            var cars = await _carService.GetAllAsync();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetById(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            if (car == null) return NotFound();
            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> Create(Car car)
        {
            var created = await _carService.CreateAsync(car);
            return CreatedAtAction(nameof(GetById), new { id = created.CarId }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Car car)
        {
            if (id != car.CarId) return BadRequest("ID mismatch.");
            var updated = await _carService.UpdateAsync(id, car);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _carService.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
