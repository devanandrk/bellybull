using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.BAL;

namespace WebApplication1.Controllers
{
    public class TextboxController : Controller
    {
        // GET: Textbox
        public ActionResult BeginPage()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult savestd(textbox obj) {

            StudentBL std = new StudentBL();


            int res = std.SaveStudent(obj);

            if (res != 0) {
                ViewBag.Result = "kjhjgkjhjkh";
            }

            return View("Index", obj);
        }

        public ActionResult GetList()
        {
            textbox obj = new textbox();
            StudentBL std = new StudentBL();


            obj.listget = std.getlist();

            return View("Index", obj);
        }
    }
}