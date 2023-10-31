﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace BucStop.Models
{
    public class Game
    {
        public int Id { get; set; }

        public GameInfo[] Info { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Thumbnail { get; set; }

        /*public async Task OnGet([FromServices] MicroClient microClient)
        {
            Info = await microClient.GetGamesAsync  ();
        } */
    }
}
