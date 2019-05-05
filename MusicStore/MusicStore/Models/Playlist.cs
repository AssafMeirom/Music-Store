using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Playlist
    {
        public String Name { get; set; }
        public Artist artist { get; set; }

        public RecordLabel Recordlabel { get; set; }
        public String genre { get; set; }




    }
}