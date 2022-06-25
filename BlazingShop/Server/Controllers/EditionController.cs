using BlazingShop.Server.Services.EditionService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : ControllerBase
    {
        private readonly IEditionService _editionService;

        public EditionController(IEditionService editionService)
        {
            _editionService = editionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Edition>>> GetEditionsAsync()
        {
            return Ok(await _editionService.GetEditions());
        }
    }
}
