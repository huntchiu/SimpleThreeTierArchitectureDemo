using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleThreeTierArchitectureDemo.Models.Entities
{
    public class Employee : BaseEntity
    {
        public String Name { get; set; } = String.Empty;
    }
}