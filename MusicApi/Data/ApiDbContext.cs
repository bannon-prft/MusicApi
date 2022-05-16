using Microsoft.EntityFrameworkCore;
using MusicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Data
{
    public class ApiDbContext : DbContext
    {
        // constructor, provide DB connection info to
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }

        public DbSet<Song> Songs { get; set; }
    }
}
