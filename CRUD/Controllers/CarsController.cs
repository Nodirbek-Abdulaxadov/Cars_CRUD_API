using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers;

[Route("api/cars")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ICarInterface _carInterface;

    public CarsController(ICarInterface carInterface)
    {
        _carInterface = carInterface;
    }

    [HttpGet("hammasi")]
    public async Task<IActionResult> GetCars()
    {
        var list = await _carInterface.GetCarsAsync();
        return Ok(list);
    }

    [HttpGet("bitta/{id}")]
    public async Task<ActionResult<Car>> GetCar(Guid id)
    {
        var car = await _carInterface.GetCarAsync(id);

        return Ok(car);
    }

    [HttpPost("yaratish")]
    public async Task<IActionResult> Create(AddCarDto car)
    {
        await _carInterface.AddCarAsync(car);
        return Ok(car);
    }

    [HttpPut("tahrirlash")]
    public IActionResult Edit(Car car)
    {
        _carInterface.UpdateCar(car);

        return Ok(car);
    }

    [HttpDelete("ochir/{id}")]
    public IActionResult Delete(Guid id)
    {
        _carInterface.DeleteCar(id);
        return Ok();
    }
}