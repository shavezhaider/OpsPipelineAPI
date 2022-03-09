using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpsPipelineAPI.Manager.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FillOptionsController : ApiControllerBase
    {
        
        public FillOptionsController(IMediator mediator) : base(mediator)
        {            

        }
        [AllowAnonymous]
        [HttpGet("GetOptions/{type}")]
        public async Task<IActionResult> GetEntirePipeline(int type)
        {
            var query = new OptionsQuery(type);
            var result = await QueryAsync(query);
            return (result != null) ? (IActionResult)Ok(result) : NoContent();
            


        }
    }
}
