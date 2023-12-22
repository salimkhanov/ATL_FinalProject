using Microsoft.AspNetCore.Identity;
using SimpleQueue.Application.DTOs.User.CreateUpdateDtos;
using SimpleQueue.Application.Services.Admin.Abstract;
using SimpleQueue.Domain.Entities;

namespace SimpleQueue.Application.Services.Admin.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public AccountService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public bool RegisterUser(UserCreateDTO userRegisterViewModel)
        {
            AppUser user = new AppUser()
            {
                UserName = userRegisterViewModel.UserName,
                Email = userRegisterViewModel.Email,
                FirstName = userRegisterViewModel.FirstName,
                LastName = userRegisterViewModel.LastName,
            };
            var result = _userManager.CreateAsync(user, userRegisterViewModel.Password).Result;
            return result.Succeeded;

            //return false;   
        }

        public bool UpdateUser (UserUpdateDTO userUpdateViewModel)
        {
            AppUser user =  _userManager.FindByIdAsync(userUpdateViewModel.Id.ToString()).Result;
            
            if (user != null) 
            {
                user.UserName = userUpdateViewModel.UserName;
                user.Email = userUpdateViewModel.Email;
                user.FirstName = userUpdateViewModel.FirstName; 
                user.LastName = userUpdateViewModel.LastName;

               var result = _userManager.UpdateAsync(user).Result;

                return result.Succeeded;
            }
            else
            {
                return false;
            }
            
        }
    }
}