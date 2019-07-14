using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Service
{
    public class AccountBookService
    {
      

        /// <summary>
        /// 取得記帳本全部資料
        /// </summary>
        /// <returns></returns>
        public static List<SpendingViewModels> GetAccountBookList()
        {
            SkillTreeHomeworkEntities _db=new SkillTreeHomeworkEntities();
            List<SpendingViewModels> ViewModles =new List<SpendingViewModels>();

             var AccountBookList = _db.AccountBook.ToList();
             SpendingViewModels item=new SpendingViewModels();

             foreach (var VARIABLE in AccountBookList)
             {
                item = new SpendingViewModels
                {
                    Category = VARIABLE.Categoryyy.ToString(),
                    Amount = VARIABLE.Amounttt,
                    Day = VARIABLE.Dateee,
                    Remarks = VARIABLE.Remarkkk

                };
                ViewModles.Add(item);
            }

             return ViewModles;
        }
    }
}