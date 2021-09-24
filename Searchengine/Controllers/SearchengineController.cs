using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Searchengine.Controllers
{
    public class SearchengineController : Controller
    {
        #region get data of searchengine which needs to be bind in dropdown

        public ActionResult Index()
        {
            return View();
        }

        #endregion

    }
}