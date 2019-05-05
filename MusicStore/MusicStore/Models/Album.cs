using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        public int Id { get; set; }
        public Artist artist { get; set; } 
        public Song songs { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal price { get; set; }
        public String genre { get; set; }
        



    }
}