using BusinessAccess.Part;
using DataModel.Part;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    public class PartController : Controller
    {
        private readonly IPartService _partService;
        public PartController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PartCreateDTO request)
        {
            var res = await _partService.Create(request);
            return Ok(res);
        }
    }
}
