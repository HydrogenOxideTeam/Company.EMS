// using Company.EMS.CQS.Commands.CreateExample;
// using Company.EMS.CQS.Queries.GetExample;
// using Company.EMS.Data;
// using Company.EMS.Models.Entities;
// using MediatR;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
//
// namespace Company.EMS.Controllers;
//
// /// <summary>
// /// heelll
// /// </summary>
// /// <param name="mediator"></param>
// [ApiController]
// [Route("[controller]")]
// public class ExampleController(IMediator mediator, ApplicationDbContext context) : ControllerBase
// {
//     private readonly IMediator _mediator = mediator;
//     private readonly ApplicationDbContext _context = context;
//     /// <summary>
//     /// Example SwaggerDoc Endpoint
//     /// </summary>
//     /// <param name="request">ExampleParam</param>
//     /// <returns>ExampleReturn</returns>
//     ///<remarks>
//     /// DOCS: https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&amp;tabs=visual-studio
//     /// Sample request:
//     ///
//     ///     POST /Todo
//     ///     {
//     ///        "id": 1,
//     ///        "name": "Item #1",
//     ///        "isComplete": true
//     ///     }
//     ///
//     /// </remarks>
//     /// <response code="201">Returns the newly created item</response>
//     /// <response code="400">If the item is null</response>
//     [HttpGet]
//     [Route("{id}")]
//     public async Task<IActionResult> GetExample(GetExampleRequest request)
//     {
//         var result = await _mediator.Send(new GetExampleQuery(request));
//         return Ok(result);
//     }
//
//     [HttpPost]
//     [Authorize]
//     [Route("createExample")]
//     public async Task<IActionResult> CreateExample(CreateExampleRequest request)
//     {
//         var result = await _mediator.Send(new CreateExampleCommand(request));
//         //return BadRequest(result);
//         return Ok();
//     }
// }