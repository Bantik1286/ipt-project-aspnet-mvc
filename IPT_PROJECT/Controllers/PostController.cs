using IPT_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPT_PROJECT.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Post()
        {
            var Post = new Post() { PostId = 101 };
            return View(Post);
        }
    }
}