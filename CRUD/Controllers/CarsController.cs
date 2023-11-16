using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers;

[Route("api/cars")]
[ApiController]
public class CarsController : ControllerBase
{
    List<Car> cars = new()
    {
        new Car()
        {
            Id = Guid.Parse("1059a045-81a6-4eda-8160-87148a59a883"),
            Brand = "Ford",
            Name = "Mustang",
            Price = 35000,
            ImageUrl = "https://imgd.aeplcdn.com/1280x720/cw/ec/23766/Ford-Mustang-Exterior-126883.jpg"
        },
        new Car()
        {
            Id = Guid.Parse("1159a045-81a6-4eda-8160-87148a59a883"),
            Brand = "Chevrolet",
            Name = "Corvette",
            Price = 40000,
            ImageUrl = "https://image.cnbcfm.com/api/v1/image/106028699-1563535545675gettyimages-1156442359.jpeg"
        },
        new Car()
        {
            Id = Guid.Parse("1059a045-81a6-4eda-8a60-87148a59a883"),
            Brand = "Dodge",
            Name = "Challenger",
            Price = 30000,
            ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/dg020-105cl-1574257068.jpg"
        },
    };
    private readonly ICarInterface carInterface;

    public CarsController(ICarInterface carInterface)
    {
        this.carInterface = carInterface;
    }

    [HttpGet("hammasi")]
    public async Task<IActionResult> GetCars()
    {
        var list = await carInterface.GetAllAsync();
        return Ok(cars);
    }

    [HttpGet("bitta/{id}")]
    public ActionResult<Car> GetCar(Guid id)
    {
        if (!cars.Any(c => c.Id == id))
            return NotFound();

        return Ok(cars.First(c => c.Id == id));
    }

    [HttpPost("yaratish")]
    public IActionResult Create(Car car)
    {
        cars.Add(car);
        return Ok(cars);
    }

    [HttpPut("tahrirlash")]
    public IActionResult Edit(Car car)
    {
        if (!cars.Any(c => c.Id == car.Id))
            return NotFound();

        foreach (var c in cars)
            if (c.Id == car.Id)
            {
                c.Brand = car.Brand;
                c.Name = car.Name;
                c.Price = car.Price;
                c.ImageUrl = car.ImageUrl;
            }

        return Ok(cars);
    }

    [HttpDelete("ochir/{id}")]
    public IActionResult Delete(Guid id)
    {
        if (!cars.Any(c => c.Id == id))
            return NotFound();

        cars.Remove(cars.First(c => c.Id == id));
        return Ok(cars);
    }
}