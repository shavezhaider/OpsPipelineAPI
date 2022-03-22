using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Manager.Command.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ApiControllerBase
    {
        
        public ReportsController(IMediator mediator) : base(mediator)
        {
            

        }
        [AllowAnonymous]
        [HttpPost("EntirePipelineReport")]
        public async Task<IActionResult> EntirePipelineReport(ReportsRequest reportsRequest)
        {
            var Query = new ReportsCommand(reportsRequest);
            var result = await CommandAsync(Query); 
            return Ok();

        }
        }
    }
