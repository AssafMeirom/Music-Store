﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String genre { get; set; }
        public Album albums { get; set; }
        public Playlist playlists { get; set; }



    }
}