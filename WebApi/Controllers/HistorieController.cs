using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using BLL_EF.ServiceImplementation;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorieController : Controller
    {
        private IHistorieBLL historieBLL = new HistorieBLL();
        /*
        public IActionResult Index()
        {
            return View();
        }*/
        [HttpGet("/{strona}/{liczbaNaStrone}")]
        public IEnumerable<HistoriaResponseDTO> get(int strona, int liczbaNaStrone)
        {
            return historieBLL.getStronicowanie(strona, liczbaNaStrone);
        }
    }
}
