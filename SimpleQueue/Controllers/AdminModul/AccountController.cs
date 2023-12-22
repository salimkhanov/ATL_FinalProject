using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleQueue.Application.DTOs.User.CreateUpdateDtos;
using SimpleQueue.Application.Services.Admin.Abstract;

namespace SimpleQueue.Controllers.AdminModul
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService service)
        {
            _accountService = service;
        }

        /// <summary>
        /// Istifadeci insert etmek ucun
        /// </summary>
        /// <param name="userRegisterViewModel"></param>
        /// <returns></returns>
        [HttpPost("AddUserToSystem")]
        public ActionResult RegisterUser(UserCreateDTO userRegisterViewModel)
        {
            var operationResult = _accountService.RegisterUser(userRegisterViewModel);
            return Ok(operationResult);
        }


        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateUser(UserUpdateDTO userUpdateViewModel)
        {
           return Ok (_accountService.UpdateUser(userUpdateViewModel));
        }

        
    }
}