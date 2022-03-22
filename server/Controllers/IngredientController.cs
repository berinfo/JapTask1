using Microsoft.AspNetCore.Mvc;
using server.Dtos;
using server.Models;
using server.Response;
using server.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetIngredientDto>>>> GetIngredients()
        {
            return Ok(await _ingredientService.GetIngredients());
        }
    }
}
