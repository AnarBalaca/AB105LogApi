using AutoMapper;
using BlogApp.Core.DTOs.Account;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.MapProfiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<RegisterDto, AppUser>();
        }

    }
}
