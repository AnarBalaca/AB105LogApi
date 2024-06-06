using BlogApp.Core.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> Register(RegisterDto registerDto);

    }
}
