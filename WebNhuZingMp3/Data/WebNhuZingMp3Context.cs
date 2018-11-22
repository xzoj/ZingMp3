using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebNhuZingMp3.Data;

namespace WebNhuZingMp3.Models
{
    public class WebNhuZingMp3Context : DbContext
    {
        public WebNhuZingMp3Context (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebNhuZingMp3.Models.Song> Song { get; set; }
    }
}
