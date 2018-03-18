using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagmentApi.Models
{
    public class Employee
    {

        public int ID { get; set; }

        [Required]
        public string firstname { get; set; }

        public string lastname { get; set; }
    }
}