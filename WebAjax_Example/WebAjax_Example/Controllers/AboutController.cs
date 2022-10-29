using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAjax_Example.Models;

namespace WebAjax_Example.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        #region Sample
        [HttpPost]
        public JsonResult GetDataDemo(Employee DemoEmployee)
        {
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 1, Name = "AAa1" });
            listEmployee.Add(new Employee() { Id = 2, Name = "BBB1" });
            listEmployee.Add(new Employee() { Id = 3, Name = "CCC" });
            listEmployee.Add(new Employee() { Id = 4, Name = "DD" });
            listEmployee.Add(new Employee() { Id = 5, Name = "EEE" });
            return Json(listEmployee, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}