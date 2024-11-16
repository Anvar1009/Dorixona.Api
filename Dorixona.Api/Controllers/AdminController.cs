//using MediatR;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace Dorixona.Api.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    //[Authorize(Roles = "Admin")]
//    public class AdminController : ControllerBase
//    {
//        private readonly ISender _sender;

//        public AdminController(ISender sender)
//        {
//            _sender = sender;
//        }
//        [HttpGet]
//        public async Task<IActionResult> BuyurtmalarniKorish()
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpPut]
//        public async Task<IActionResult> BuyurtmaniTasdiqlash(Guid Id, string Comment)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpGet]
//        public async Task<IActionResult> DorilarRoyxati()
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpPost]
//        public async Task<IActionResult> DoriQoshish(string DoriNomi, int Narxi, int Soni)
//        {
//            try
//            {
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//    }
//}
