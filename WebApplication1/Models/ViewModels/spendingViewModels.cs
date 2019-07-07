using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class SpendingViewModels
    {
        [Display(Name = "流水號")] public int SM { get; set; }

        [Display(Name = "類別")] public string Category { get; set; }

        [Display(Name = "日期")]
        public DateTime Day { get; set; }

        [Display(Name = "金額")] public string Amount { get; set; }

        [Display(Name = "備註")] public string Remarks { get; set; }
    }

    public class SpendingListViewModels
    {
        public SpendingViewModels spending { get; set; }
        public List<SpendingViewModels> SpendingList { get; set; }
    }
}