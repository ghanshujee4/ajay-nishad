using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Sql;
using Angularmvc.Models;

namespace Angularmvc.Controllers
{
    public class AngmvcController : Controller
    {
        //
        // GET: /Angmvc/
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getAll()
        {
            using (SampleDBEntities dataContext = new SampleDBEntities())
            {
                var employeeList = dataContext.AngmvcModels.ToList();
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult getEmployeeByNo(string EmpNo)
        {
            using (SampleDBEntities dataContext = new SampleDBEntities())
            {
                int no = Convert.ToInt32(EmpNo);
                var employeeList = dataContext.AngmvcModels.Find(no);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }
      
	}
}