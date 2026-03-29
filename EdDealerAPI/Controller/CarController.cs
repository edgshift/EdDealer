using EdDealerAPI.Data;
using EdDealerAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdDealerAPI.Controller
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        public readonly Context context;

        public CarController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await context.Cars.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var carro = await context.Cars.FirstOrDefaultAsync(x => id == x.Id);

            if (carro is null)
            {
                return BadRequest($"El {id}: id no va acorde a los id de carros registrados.");
            
            }
            return carro;
        }

        [HttpPost]
        public async Task<ActionResult> PostCar(Car car)
        {
            context.Add(car);
            await context.SaveChangesAsync();
            return Ok(); 
        }


        [HttpPut("{id:int}")]

        public async Task <ActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest($"El id {id}: no coincide con ninguno de los vehiculos.");
            }

            context.Update(car);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
