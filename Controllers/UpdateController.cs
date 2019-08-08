using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Operations_Using_EF.SqlUtility;
using CRUD_Operations_Using_EF.Models;

namespace CRUD_Operations_Using_EF.Controllers
{
    public class UpdateController : Controller
    {
        //
        // GET: /Update/

        public ActionResult Update()
        {
            return View();
        }

        //[HttpPut]
        //public ActionResult Update(Student modelData)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            SqlUtilityClass.Update(modelData);
        //            ViewBag.UpdateMessage = "Data updated scuccessfully !!";
        //        }
        //        catch (Exception)
        //        {
        //            new Exception("Data could not be saved, please try again !!");
        //        }
        //        ModelState.Clear();

        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid entry of data, please try again !!");
        //    }
        //    return View();
        //}

    }
}
