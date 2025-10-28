using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPS.API.Models;
using SPS.Business.Abstractions;



namespace SPS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageSPSController : ControllerBase
    {       
        private readonly ISPSDataService _iDataService;
        public ManageSPSController(ISPSDataService iDataService)
        {
            _iDataService = iDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoleFromDB()
        {
            var result = await _iDataService.GetRoles();
            return Ok(result);
        }

    }
}
