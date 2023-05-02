using Microsoft.AspNetCore.Mvc;

namespace ClothShop.Controllers
{
    [Route("[controller]")]
    public class SneakerController : ControllerBase 
    {

        private readonly ISneakerRepository repository;

        public SneakerController(ISneakerRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetAllSneakers")]
        public async Task<ActionResult<List<Sneaker>>> GetAllSneakersAsync()
        {
            return Ok(await repository.GetAllSneakersAsync());
        }

        [HttpGet("GetSneakerById")]
        public async Task<ActionResult<List<Sneaker>>> GetSneakersByIdAsync(int id)
        {
            var response = await repository.GetSneakerByIdAsync(id);
            if(response == null)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        public async Task<ActionResult<bool>> CreateSneakerAsync(Sneaker sneaker)
        {
            var response = await repository.CreateSneakerAsync(sneaker);
            if(response == false)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        public async Task<ActionResult<List<Sneaker>>> DeleteSneakerAsync(int id)
        {
            var response = await repository.DeleteSneakerAsync(id);
            if(response == false)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}