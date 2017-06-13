using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADONET_LIB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<dynamic> test = null;
            using (Facade.TestFacade tf=new Facade.TestFacade()) //Kullan at
            {
               test= tf.TestPull();
               
            }

            return View(test);
        }
        
    }
}