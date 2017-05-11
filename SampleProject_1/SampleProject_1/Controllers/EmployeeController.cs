using MyWCFService;
using SampleProject_1.EmployeeReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWCFService.Models;


namespace SampleProject_1.Controllers
{
    public class EmployeeController : Controller
    {

        private EmployeeServiceClient esc = new EmployeeServiceClient();
      //  private EmployeeReferenceClient esc = new EmployeeReferenceClient();       
        // GET: Employee      
       
        public JsonResult GetEmployee()
        {
            List<EmployeeTBL> ListOfEmployees = esc.GetEmployees().ToList(); 
            return Json(ListOfEmployees, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoginDetailsCtrl(LoginData d)
        {
            var user = esc.LoginDetails(d);
            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}