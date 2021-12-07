using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruchininpz.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int AlbumTitle { get; set; }

        public List<Song> Songs { get; set; }
        public Artist Artist { get; set; }
    }
}
