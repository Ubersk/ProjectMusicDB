using kruchininpz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruchininpz
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }
    }
}
