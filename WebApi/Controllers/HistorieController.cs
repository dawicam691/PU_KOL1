using BLL.DTOModels.Response;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorieController : Controller
    {/*
        public IActionResult Index()
        {
            return View();
        }*/
        [HttpGet("/{strona}/{liczbaNaStrone}")]
        public IEnumerable<HistoriaResponseDTO> get(int strona, int liczbaNaStrone)
        {

        }
    }
}
