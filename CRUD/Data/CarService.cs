using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data;

public class CarService : ICarInterface
{
    private readonly CarsDbContext _dbContext;

    public CarService(CarsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddCarAsync(AddCarDto car)
    {
        _dbContext.Cars.Add(new Car()
        {
            Id = Guid.NewGuid(),
            Name = car.Name,
            Brand = car.Brand,
            Price = car.Price,
            ImageUrl = car.ImageUrl
        });
        await _dbContext.SaveChangesAsync();
    }

    public void DeleteCar(Guid id)
    {
        var car = _dbContext.Cars.FirstOrDefault(x => x.Id == id);
        _dbContext.Cars.Remove(car);
        _dbContext.SaveChanges();
    }

    public async Task<Car> GetCarAsync(Guid id)
    {
        var car =  _dbContext.Cars.FirstOrDefault(x => x.Id == id);
        return car ?? new Car();
    }

    public async Task<List<Car>> GetCarsAsync()
        => await _dbContext.Cars.ToListAsync();

    public void UpdateCar(Car car)
    {
        _dbContext.Cars.Update(car);
        _dbContext.SaveChanges();
    }
}
