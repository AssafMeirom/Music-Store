using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public Playlist playlists { get; set; }
        public Artist Favorites { get; set; }
        public Song Likes { get; set; }




    }
}