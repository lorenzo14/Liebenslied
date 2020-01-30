using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace pryecto.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Song> songs { get; set; }

        public ModelContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=proyecto;Integrated Security=True") { }
    }
}