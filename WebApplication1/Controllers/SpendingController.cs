using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;
using WebApplication1.Service;

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
                SpendingList = AccountBookService.GetAccountBookList()
            };

            List<SelectListItem> mySelectItemList = new List<SelectListItem>();
            mySelectItemList.AddRange(new[]{
                new SelectListItem() {Text = "支出", Value = "0"},
                new SelectListItem() {Text = "收支", Value = "1"}
            });
            //取得資料

            //SpendingViewModels tempspending = new SpendingViewModels();
            //DateTime dateTimeMin = new DateTime(2019,01,01);
            //Random rnd = new Random();

            //string tempCategory = "";
            //ViewData["CategoryList"] = mySelectItemList;
            //for (int i = 1; i <= 100; i++)
            //{
            //    tempspending=new SpendingViewModels();
            //    //tempspending.SM = i;
            //    temp666 = rnd.Next(2).ToString();
            //    tempspending.Category= mySelectItemList.Where(x=>x.Value== tempCategory).SingleOrDefault().Text ;
            //    tempspending.Day= dateTimeMin.AddDays(rnd.Next(365));
            //    tempspending.Amount = rnd.Next(2000);
            //    models.SpendingList.Add(tempspending);
            //}
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
