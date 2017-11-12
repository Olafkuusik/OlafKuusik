using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OlafKuusik.Models
{
    public class Client
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }

        [Range(16,80)]
        public int Age { get; set; }

        public DateTime JoiningDate { get; set; }
    }

    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}