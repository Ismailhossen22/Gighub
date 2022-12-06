using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new GigViewModel
            {
                Genres = _context.Genres.ToList()

            };

            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult create(GigViewModel gigviewmodel)
        {
            if (!ModelState.IsValid)
            {

                gigviewmodel.Genres = _context.Genres.ToList();
                return View("Creat", gigviewmodel);
            }
               

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = gigviewmodel.GetDateTime(),

                GenreId = gigviewmodel.Genre,

                Venue = gigviewmodel.Venue



            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("index", "home");

        }
    }
}


