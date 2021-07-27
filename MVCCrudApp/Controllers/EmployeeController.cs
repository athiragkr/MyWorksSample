﻿using MVCCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<MVCEmployeeModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<MVCEmployeeModel>>().Result;
            return View(empList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new MVCEmployeeModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCEmployeeModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult AddOrEdit(MVCEmployeeModel emp)
        {
            if (emp.EmployeeId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employees", emp).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employees/" + emp.EmployeeId, emp).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employees/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}




