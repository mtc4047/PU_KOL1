using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GrupaController : ControllerBase
    {
        private readonly IGrupaService _grupaService;
        public GrupaController(IGrupaService grupaService)
        {
            _grupaService = grupaService;
        }

        [HttpGet("GetFullName")]
        public IActionResult GetHistoria(int id)
        {
            try
            {
                var fullName = _grupaService.getFullGrupaName(id);
                return Ok(fullName);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while getting full group name list: \r\n" + ex.Message);
            }
        }
    }
}
