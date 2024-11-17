using Dorixona.Application.Customers.Command.EmployeCommand;
using Dorixona.Application.Customers.Query.EmployeQuery;
using Dorixona.Domain.Models.EmployeModel;
using Dorixona.Domain.Models.EmployeModel.DTO;
using Dorixona.Domain.Models.OrderModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Dorixona.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Dorixona.Api.Controllers
{
    /// <summary>
    ///  [Authorize]
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly ISender _sender;

        public EmployeController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(
            string EmployeId,
            CancellationToken cancellationToken)
        {
            Guid guid = Guid.Parse(EmployeId);

            var query = new GetEmployeQuery(guid);

            var result = await _sender.Send(query, cancellationToken);

            return Ok(result);
            //return result.IsSuccess ? Ok(result) : BadRequest(EmployeError.NotFound);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployeModel(
        CreateEmployeDTO model,
        CancellationToken cancellationToken)
        {
            var command = new CreateCommandEmploye(model);

            var result = await _sender.Send(command, cancellationToken);

            return result.IsSuccess ? Ok(result) : BadRequest(EmployeError.EmployeNull);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployeModel(
        UpdateEmployeDTO model,
        CancellationToken cancellationToken)
        {
            var command = new UpdateCommandEmploye(model);

            var result = await _sender.Send(command, cancellationToken);

            return result.IsSuccess ? Ok(result) : BadRequest(EmployeError.EmployeNull);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmploye(
        DeleteEmployeDTO model,
        CancellationToken cancellationToken)
        {
            var command = new DeleteCommandEmploye(model);

            var result = await _sender.Send(command, cancellationToken);

            return result.IsSuccess ? Ok(result) : BadRequest(EmployeError.EmployeNull);
        }
    }
}
