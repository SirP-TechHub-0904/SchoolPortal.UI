using Hrssu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Hrssu.Models.Entities;
using System.Data.Entity;

namespace Hrssu.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Gallery()
        {

            var gallery = db.ImageGallery.Where(x => x.CurrentGallery == true).Take(3).ToList();

            return View(gallery);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult _Slider()
        {
            var slider = db.ImageSlider.Where(x => x.CurrentSlider == true);

            return PartialView(slider);
        }
        public ActionResult _Gallery()
        {
            var gallery = db.ImageGallery.Where(x => x.CurrentGallery == true);

            return PartialView(gallery);
        }
        public ActionResult _News()
        {
            var post = db.Posts.Include(x => x.PostImages).Where(x => x.PageType == Models.Entities.PageType.News && x.Status == Models.Entities.PostStatus.Published && x.WhoCanSeePost == Models.Entities.WhoSeePost.All).Take(3).ToList();
            return PartialView(post);
        }

        public ActionResult _NewsFotter()
        {
            var post = db.Posts.Include(x => x.PostImages).Where(x => x.PageType == Models.Entities.PageType.News && x.Status == Models.Entities.PostStatus.Published && x.WhoCanSeePost == Models.Entities.WhoSeePost.All).Take(3).ToList();
            return PartialView(post);
        }

        public async Task<ActionResult> BlogDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var post = await db.Posts.Include(x => x.PostImages).FirstOrDefaultAsync(x => x.Id == id);
            //Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

    }
}