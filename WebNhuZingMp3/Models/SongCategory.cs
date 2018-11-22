using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNhuZingMp3.Models
{
    public class SongCategory
    {
        public Song Song { get; set; }
        public Category Category { get; set; }
        public int SongId { get;  set; }
        public int CategoryId { get;  set; }
    }
}
