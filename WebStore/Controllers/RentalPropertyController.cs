using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class RentalPropertyController : Controller
    {
        public ActionResult All()
        {
            return null;
        }
        
        // get a specific property, display details and list all units:
        public ActionResult RentalProperty(string rentalPropertyName)
        {
            return null;
        }


        // get a specific unit at a specific property:
        public ActionResult Unit(string rentalPropertyName, string unitNo)
        {            
            return null;
        }
    }
}