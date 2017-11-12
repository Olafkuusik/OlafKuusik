using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OlafKuusik.Models
{
    public class VideoGame
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ItemsInStock { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
    public class VideoGameDBContext : DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }
    }
}