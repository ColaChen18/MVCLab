﻿using OneCenter.BLL.Admin;
using OneCenter.Models.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneCenter.Web.Controllers
{
    public class AdminController : Controller
    {
        /// <summary>
        /// AdminService
        /// </summary>
        private AdminService _service;

        /// <summary>
        /// AdminController Constructor
        /// </summary>
        public AdminController()
        {
            this._service = new AdminService();
        }

        // GET: Admin
        public ActionResult Index()
        {
            var result = this._service.GetAdmins();
            return View(result);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdminViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }
                this._service.AddAdmin(model);
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}