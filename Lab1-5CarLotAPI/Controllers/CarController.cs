using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_5CarLotAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public List<Car> carLot = new List<Car>
        {
            new Car("Ford", "Bronco", 1985, Colors.red),
            new Car("Ford", "Escort", 1986, Colors.blue),
            new Car("Chevrolet", "Caprice", 1983, Colors.purple),
            new Car("Honda", "Accord", 1990, Colors.grey),
            new Car("Cadillac", "El Dorado", 1985, Colors.black),
            new Car("Lincoln", "Continental", 1985, Colors.red),
            new Car("Ford", "F150", 1975, Colors.blue),
            new Car("Honda", "Civic", 1985, Colors.white),
            new Car("Toyota", "Tacoma", 1992, Colors.purple),
            new Car("Toyota", "Tercel", 1992, Colors.silver),
        };

        [HttpGet]
        public List<Car> GetAllCars()
        {
            return carLot;
        }

        [HttpGet("{index}")]
        public Car GetSpecificCar(int index)
        {
            return carLot[index];
        }

        [HttpGet("SearchByColor/{color}")]
        public List<Car> GetCarsByColor(string color)
        {
            List<Car> colorList = carLot.Where(x => x.Color.ToString().Contains(color.ToLower())).ToList();
            return colorList;
        }

        [HttpGet("SearchByYear/{year}")]
        public List<Car> GetCarsByYear(int year)
        {
            List<Car> yearList = carLot.Where(x => x.Year==year).ToList();
            return yearList;
        }

        [HttpGet("SearchByMake/{make}")]
        public List<Car> GetCarsByMake(string make)
        {
            List<Car> makeList = carLot.Where(x => x.Make.ToLower() == make.ToLower()).ToList();
            return makeList;
        }
    }
}
