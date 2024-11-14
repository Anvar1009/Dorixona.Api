using Dorixona.Application.Customers.Query.GetPill;
using Dorixona.Domain.Models.OrderModel;
using Dorixona.Domain.Models.PillModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dorixona.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize(Roles = "User")]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        public CustomerController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<IActionResult> DorilarRoyhati(CancellationToken cancellationToken)
        {
            try
            {
                var query = new GetPillQuery();
                var result = await _sender.Send(query, cancellationToken);

                return result.IsSuccess ? Ok(result) : BadRequest(PillError.NotFound);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> BuyurtmaBerish(Guid Id, int DoriSoni, string Manzil)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> BuyurtmaHolatiniTekshirish()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
