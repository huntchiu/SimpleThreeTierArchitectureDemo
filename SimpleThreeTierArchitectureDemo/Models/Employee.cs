using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleThreeTierArchitectureDemo.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public String Name { get; set; } = String.Empty;
    }
}