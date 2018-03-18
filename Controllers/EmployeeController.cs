﻿using EmployeeManagmentApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmployeeManagmentApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        // GET: api/GetEmployee
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{ ID=1, firstname="Pranay", lastname="Rana"},
                new Employee{ ID=2, firstname="abc", lastname="xyz" }
            };

            return emplist;
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
