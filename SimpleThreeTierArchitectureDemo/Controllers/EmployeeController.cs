using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleThreeTierArchitectureDemo.Models;
using SimpleThreeTierArchitectureDemo.Models.DTOs;
using SimpleThreeTierArchitectureDemo.Models.Entities;
using SimpleThreeTierArchitectureDemo.Models.Requests;
using SimpleThreeTierArchitectureDemo.Models.Responses;
using SimpleThreeTierArchitectureDemo.Services;

namespace SimpleThreeTierArchitectureDemo.Controllers
{

    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : GenericController<Employee, EmployeeDTO, EmployeeRequestModel, EmployeeResponseModel>
    {
        public EmployeeController(GenericService<Employee, EmployeeDTO> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}