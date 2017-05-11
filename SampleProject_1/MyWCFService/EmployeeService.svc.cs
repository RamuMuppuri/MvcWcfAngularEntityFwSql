using MyWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private EmployeeDBContext edm = new EmployeeDBContext();
        public List<EmployeeTBL> GetEmployees()
        {
            return edm.EmployeeTBLs.ToList();
        }
        public UsersTBL LoginDetails(LoginData data)
        {
            var user = edm.UsersTBLs.Where(a => a.UserName.Equals(data.UserName) && a.password.Equals(data.password)).FirstOrDefault();
            return user;
        }
    }
}
