using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Operations_Using_EF.Models;
using System.Configuration;
using System.Data.SqlClient;
using CRUD_Operations_Using_EF.SqlUtility;

namespace CRUD_Operations_Using_EF.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student modelData)
        {
            if (ModelState.IsValid)
            {
                    try
                    {
                        SqlUtilityClass.Insertion(modelData);
                    ViewBag.SuccessMessage = "Data saved scuccessfully !!";
                    }
                    catch (Exception)
                    {
                        new Exception("Data could not be saved, please try again !!");
                    }
                    ModelState.Clear();  
            
        }
            else
            {
                Console.WriteLine("Invalid entry of data, please try again !!");
            }

            Response.Redirect("~/Student/UpdateData");
            
            return View();

           
        }

        public ActionResult UpdateData(Student modelData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SqlUtilityClass.Update(modelData);
                    ViewBag.UpdateMessage = "Data updated scuccessfully !!";
                }
                catch (Exception)
                {
                    new Exception("Data could not be saved, please try again !!");
                }
                ModelState.Clear();

            }
            else
            {
                Console.WriteLine("Invalid entry of data, please try again !!");
            }
            return View();
        }

        //[HttpDelete]
        public ActionResult Delete(Student modelData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SqlUtilityClass.Delete(modelData);
                    ViewBag.UpdateMessage = "Data deleted scuccessfully !!";
                }
                catch (Exception)
                {
                    new Exception("Data could not be deleted, please try again !!");
                }
                ModelState.Clear();

            }
            else
            {
                Console.WriteLine("Something went wrong, please try again !!");
            }
            return View();
        }

        public ActionResult Details(Student modelData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SqlUtilityClass.StudentDetails(modelData);
                    ViewBag.UpdateMessage = "Data deleted scuccessfully !!";
                }
                catch (Exception)
                {
                    new Exception("Data could not be deleted, please try again !!");
                }
                ModelState.Clear();

            }
            else
            {
                Console.WriteLine("Something went wrong, please try again !!");
            }
            return View(modelData);
        }

    }
}