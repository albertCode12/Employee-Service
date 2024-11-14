using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public partial class Employee
    {
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public string Ssn { get; set; }
        public DateTime? Bdate { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public decimal? Salary { get; set; }
        public string SuperSsn { get; set; }
        public int Dno { get; set; }
    }
}
