using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SimpleThreeTierArchitectureDemo.Models.DTOs;
using SimpleThreeTierArchitectureDemo.Models.Entities;
using SimpleThreeTierArchitectureDemo.Models.Requests;
using SimpleThreeTierArchitectureDemo.Models.Responses;

namespace SimpleThreeTierArchitectureDemo.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeRequestModel, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeDTO, EmployeeResponseModel>().ReverseMap();
        }
    }
}