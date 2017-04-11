using MyWCFService;
using SampleProject_1.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SampleProject_1.Controllers
{
    public class EmployeeController : Controller
    {

        private EmployeeServiceClient esc = new EmployeeServiceClient();
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee      
       
        public JsonResult GetEmployee()
        {
            List<EmployeeTBL> ListOfEmployees = esc.GetEmployees().ToList(); 
            return Json(ListOfEmployees, JsonRequestBehavior.AllowGet);
        }
    }
    public class EmployeeFetchController : Controller
    {
        public ViewResult ReturnHomeView()
        {
            return View();
        }
    }

    public class EmployeePostController : Controller
    {
        public ViewResult ReturnEmpPostView()
        {
            return View();
        }
    }
}