using homework_week1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework_week1.Controllers
{
    
    public class EFController : Controller
    {
       private 客戶資料Entities db =new 客戶資料Entities();
        // GET: EF
        public ActionResult Index()
        {
            var data = db.vw_CustomerCount;
            return View(data);
        }
    }
}