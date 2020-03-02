using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;
using MyApp.DB.DBOperations;
namespace MVCAppWithDB.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }


        empRepository repository = null;
        public HomeController()
        {
            repository = new empRepository();
        }



        public ActionResult Create()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddEmployee(model);
                if (id > 0)
                {
                    ModelState.Clear();
                }
            }
            return View();
        }
         [AllowAnonymous]
        public ActionResult GetEmployee()
        {

            var Result = repository.GetAllEmployee();
            //ViewBag.Message = "Your contact page.";

            return View(Result);
        }


        public ActionResult GetEmployeeId(int Id)
        {

            var Result = repository.GetEmployee(Id);
            //ViewBag.Message = "Your contact page.";

            return View(Result);
        }

        public ActionResult Edit(int Id)
        {

            var Result = repository.GetEmployee(Id);
            //ViewBag.Message = "Your contact page.";

            return View(Result);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel model)
        {

            var Result = repository.EditEmployee(model.Id, model);
            //ViewBag.Message = "Your contact page.";

            return View(Result);
        }



        [HttpGet]
        public ActionResult Delete(int Id)
        {

            bool Result = repository.deleteEmployee(Id);
            //ViewBag.Message = "Your contact page.";

            return RedirectToAction("GetEmployee");
        }


       
        //[HttpPost]
        //public ActionResult Delete(int Id)
        //{

        //    bool Result = repository.deleteEmployee(Id);
        //    //ViewBag.Message = "Your contact page.";

        //    return RedirectToAction("GetEmployee");
        //}

    }
}