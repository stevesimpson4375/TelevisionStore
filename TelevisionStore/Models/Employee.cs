using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TelevisionStore.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
    }
}