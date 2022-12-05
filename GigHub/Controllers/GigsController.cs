﻿using System;
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
            _context=new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new GigViewModel
            {
              Genres= _context.Genres.ToList()

            };

            return View( ViewModel);
        }

        //[Authorize]
        //[HttpPost]
        //public ActionResult Create(GigViewModel gigViewModel)
        //{
        //    //  var artist = _context.Users.Single(u => u.Id == artistId);
        //  //  var genre = _context.Genres.Single(g => g.Id == gigViewModel.Genre);

        //    var gig = new Gig
        //    {
        //        ArtistId = User.Identity.GetUserId(),
        //        DateTime = gigViewModel.DateTime,

        //        GenreId = gigViewModel.Genre,

        //        Venue = gigViewModel.Venue



        //    };
        //     _context.Gigs.Add(gig);
        //    _context.SaveChanges();

        //    return RedirectToAction("Index","Home");
        //}
    }
}