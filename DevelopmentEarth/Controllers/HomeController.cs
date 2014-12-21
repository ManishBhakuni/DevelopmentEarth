using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevelopmentEarth.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        #region Home Controller Index Page

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region AboutUs

        public ActionResult AboutUs()
        {
            return View();
        }

        #endregion


        #region Services

        public ActionResult Services()
        {
            return View();
        }

        #endregion


        #region Terms

        public ActionResult Terms()
        {
            return View();
        }

        #endregion

        #region ContactUs

        public ActionResult ContactUs()
        {
            return View();
        }

        #endregion

    }
}
