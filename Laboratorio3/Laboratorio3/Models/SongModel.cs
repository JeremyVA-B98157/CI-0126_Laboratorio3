using Microsoft.AspNetCore.Mvc;
using System;

namespace Laboratorio3.Models
{
    public class SongModel
    {
        public string Album { get; set; }
        public string NameSong { get; set; }
        public string GenreSong { get; set; }
        public string Interpreter { get; set; }
        public int Likes { get; set; }
    }
}
