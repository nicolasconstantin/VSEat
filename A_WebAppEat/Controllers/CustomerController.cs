﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;

namespace VSEat.Controllers
{
    public class CustomerController : Controller
    {
        private IConfiguration Configuration { get; }
        private ICustomerManager CustomerManager { get; }
        public Customer customer_Id { get; }
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomerController(ICustomerManager customerManager)
        {
            CustomerManager = customerManager;
            
        }



        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Index(Customer c)
        {
            

            if (CustomerManager.isUserValid(c))
            {
                //int id = CustomerManager.c;
                var test = HttpContext.User.Identity;
                HttpContext.Session.SetString("login", c.login);

                
                //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                //var tesst = User.Identity.Name;
                return RedirectToAction("Index", "Home", new { user = c.login});
            }
            else
            {
                return View();
            }
           
            
        
            
        }


        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        // GET: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DTO.Customer c)
        {
            ICityDB cityDB = new CityDB(Configuration);
            ICityManager cityManager = new CityManager(cityDB);

            var citieslist = cityManager.GetCities();

           
            ViewBag.City = citieslist;
            CustomerManager.AddCustomer(c);
            return RedirectToAction(nameof(Index));
        }

        // POST: Customer/Create
 
        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}