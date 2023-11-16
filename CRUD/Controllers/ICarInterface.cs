
using CRUD.Models;

namespace CRUD.Controllers
{
    public interface ICarInterface
    {
        Task<List<Car>> GetAllAsync();
    }
}