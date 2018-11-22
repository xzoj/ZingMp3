using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNhuZingMp3.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string Singer { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Link { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<SongCategory> SongCategories { get; set; }

    }
}
