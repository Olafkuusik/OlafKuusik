using System;
using System.Collections.Generic;
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
}