using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //always import this namespace when creating controllers from scratch

//think of a controller as a class & an action as a method
//controller contains a variety of actions that we can route too

namespace MichaelResumeApp.Controllers
{
    public class PostsController : Controller //make sure PostsController inherits from the controller base class 

    //ActionResult most commonly used returns are Content, Redirect, File, and View

    {
        public ActionResult Index()   //declaring the Index action 
        {
            return Content("Hello, World!");
        }
    }
}