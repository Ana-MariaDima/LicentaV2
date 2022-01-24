using Licenta.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {

        private readonly IDemoService _demoService;

        public IngredienteController(IDemoService demoService)
        {
            // _context = context;
            _demoService = demoService;
        }




        //get 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _demoService.GetIngredienteRepository().GetAll();
            return Ok(result);
            //return Ok(await _context.CategorieIngredient.ToListAsync());

        }
    }
}
