using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Usings para las DataAnnotations y la migracion de CodeFirst
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pryecto.Models
{
    public class Song
    {
        //Campos de la clase
        [Key]
        [Column(Order = 1)]
        public int idCancion { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(Order = 2)]
        public string Author { get; set; }

        [Required]
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }

        //Relacion con Users
        public int PublisherId { get; set; }
        public User User { get; set; }
    }
}