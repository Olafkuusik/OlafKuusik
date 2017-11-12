using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlafKuusik.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}