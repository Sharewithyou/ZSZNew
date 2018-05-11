using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZSZ.Web.Controllers
{
    public class MailManageController : Controller
    {
        // GET: MailManage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TemplateAddPage()
        {
            return View();
        }
    }
}