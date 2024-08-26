using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleThreeTierArchitectureDemo.Models;
using SimpleThreeTierArchitectureDemo.Services;

namespace SimpleThreeTierArchitectureDemo.Controllers
{

    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : GenericController<Employee>
    {
        public EmployeeController(GenericService<Employee> service) : base(service)
        {
        }
    }
}