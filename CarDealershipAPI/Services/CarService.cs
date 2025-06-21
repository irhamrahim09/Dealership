using CarDealershipAPI.Models;
using CarDealershipAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CarDealershipAPI.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _context;

        public CarService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Car>> GetAllAsync() => await _context.Cars.ToListAsync();
        public async Task<Car?> GetByIdAsync(int id) => await _context.Cars.FindAsync(id);
        public async Task<Car> CreateAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }
        public async Task<bool> UpdateAsync(int id, Car car)
        {
            if (id != car.CarId) return false;
            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null) return false;
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
