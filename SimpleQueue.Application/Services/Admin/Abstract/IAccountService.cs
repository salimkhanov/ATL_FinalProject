using SimpleQueue.Application.DTOs.User.CreateUpdateDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Application.Services.Admin.Abstract
{
    public interface IAccountService
    {
        bool RegisterUser(UserCreateDTO userRegisterViewModel);
        public bool UpdateUser(UserUpdateDTO userUpdateViewModel);
    }
}