using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetSong();
            ViewBag.MainTitle = "My favorite song";
            return View(song);
        }

        private SongModel GetSong()
        {
            SongModel song = (new SongModel
            {
                Album = "Sin miedo(del Amor y otros Demonios)",
                NameSong = "Telepatía",
                GenreSong = "Pop",
                Interpreter = "Kali Uchis",
                Likes = 1900000
            });
            return song;
        }

    }
}
