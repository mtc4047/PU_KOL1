using BLL.ServiceInterfaces;
using BLL_EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HistoriaController : ControllerBase
    {
        private readonly IHistoriaService _historiaService;
        public HistoriaController(IHistoriaService historiaService)
        {
            _historiaService = historiaService;
        }

        [HttpGet("GetHistoria")]
        public IActionResult GetHistoria(int strona,int iloscNaStronie) 
        {
            try
            {
                var historia = _historiaService.getHistoria(strona,iloscNaStronie);
                return Ok(historia);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while getting historia list: \r\n" + ex.Message);
            }
        }
    }
}
