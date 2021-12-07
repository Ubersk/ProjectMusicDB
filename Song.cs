using kruchininpz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kruchininpz
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public float SongDuration { get; set; }

        public Album Album { get; set; }
    }
}