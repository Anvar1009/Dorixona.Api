//using Dorixona.Application.Homes.Command.ConfirmCode;
//using Dorixona.Application.Homes.Command.RegisterUser;
//using Dorixona.Application.Homes.Query.Login;
//using Dorixona.Domain.Models.UserModel;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace Dorixona.Api.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class HomeController : ControllerBase
//    {
//        private readonly ISender _sender;

//        public HomeController(ISender sender)
//        {
//            _sender = sender;
//        }
//        [HttpPost]
//        public async Task<IActionResult> RegisterUser(CreateUserDTO createUserDTO, CancellationToken cancellationToken)
//        {
//            try
//            {
//                if (!string.IsNullOrEmpty(createUserDTO.Username) 
//                    && !string.IsNullOrEmpty(createUserDTO.Password) 
//                    && !string.IsNullOrEmpty(createUserDTO.PhoneNumber) 
//                    && !string.IsNullOrEmpty(createUserDTO.FullName))
//                {
//                    var command = new CreateUserCommand(createUserDTO);

//                    var result = await _sender.Send(command, cancellationToken);

//                    return Ok(result);
//                }
//                return BadRequest(UserError.UserNull);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpPut]
//        public async Task<IActionResult> ConfirmCode(int TasdiqlashKodi, CancellationToken cancellationToken)
//        {
//            try
//            {
//                var command = new ConfirmCodeCommand(TasdiqlashKodi);

//                var result = await _sender.Send(command, cancellationToken);

//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpGet]
//        public async Task<IActionResult> Login(string UserName, string Password, CancellationToken cancellationToken)
//        {
//            try
//            {
//                var command = new LoginQuery(UserName, Password);

//                var result = await _sender.Send(command, cancellationToken);

//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }
//        }
//        [HttpPost]
//        public async Task<IActionResult> LogOut()
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
