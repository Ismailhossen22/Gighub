using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.ViewModels
{
    public class GigViewModel
    {
        [Required]
        public  string Venue { get; set; }
        [Required]
        public  string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
             return DateTime.Parse(string.Format("{ 0},{ 1}",Date,Time )); 

        }
      
        
    }
}