using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using DataModels = StudentAdminPortal.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>()
            .ReverseMap();

            CreateMap<DataModels.Gender, Gender>()
            .ReverseMap();

            CreateMap<DataModels.Address, Address>()
            .ReverseMap();
        }
    }
}
