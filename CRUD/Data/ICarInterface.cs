using CRUD.Models;

namespace CRUD.Data;

public interface ICarInterface
{
    Task<List<Car>> GetCarsAsync();
    Task<Car> GetCarAsync(Guid id);
    Task AddCarAsync(AddCarDto car);
    void UpdateCar(Car car);
    void DeleteCar(Guid id);
}
