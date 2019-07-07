﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class SpendingController : Controller
    {
        // GET: Spending
        public ActionResult Index()
        {
            SpendingListViewModels models = new SpendingListViewModels
            {
                spending = new SpendingViewModels(),
                SpendingList = new List<SpendingViewModels>()
            };
            return View(models);
        }

        // GET: Spending/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [ChildActionOnly]
        // GET: Spending/Create
        public ActionResult CreateAction()
        {
            return View();
        }

        // POST: Spending/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Spending/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Spending/Edit/5
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

        // GET: Spending/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Spending/Delete/5
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
