using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeManagement.Services;

namespace TreeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CayxanhController : ControllerBase
    {
        private readonly ICayxanhRepository _cayxanhRepository;
        public CayxanhController(ICayxanhRepository cayxanhRepository)
        {
            _cayxanhRepository = cayxanhRepository;
        }
        [HttpGet]
        public IActionResult GetAllTrees()
        {
            try {
                return Ok(_cayxanhRepository.GetAll());
            }
            catch
            {
                return BadRequest();
            }
            
        }
    }
}
