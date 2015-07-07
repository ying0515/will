using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustSite.Models;

namespace CustSite.Controllers
{
    public class CustStatusController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CustStatus
        public ActionResult Index()
        {
            return View(db.客戶資料狀況.ToList());

        }
    }
}