using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using BLL_EF.ServiceImplementation;
using BLL.DTOModels.Response;
using BLL.DTOModels.Request;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudenciController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }*/

        private IStudenciBLL studenciBLL= new StudenciBLL();
        [HttpGet]
        public IEnumerable<StudentResponseDTO> get()
        {
            return studenciBLL.get();
        }
        [HttpGet("/{id}")]
        public StudentResponseDTO getById(int id)
        {
            return studenciBLL.getById(id);
        }
        [HttpPost]
        public void add([FromBody] StudentRequestDTO studentRequestDTO)
        {
            studenciBLL.add(studentRequestDTO);
        }
        [HttpDelete("/{id}")]
        public void delete(int id)
        { 
            studenciBLL.delete(id);
        }
        [HttpPut]
        public void update([FromBody] StudentRequestDTO studentRequestDTO)
        {
            studenciBLL.update(studentRequestDTO);
        }
    }
}
