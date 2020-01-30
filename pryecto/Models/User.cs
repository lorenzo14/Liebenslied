using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Usings para las DataAnnotations y la migracion de CodeFirst
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace pryecto.Models
{
    public class User
    {
        //Campos de la clase
        [Key]
        public int Nif { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public DateTime DischargeDate { get; set; }

        public int Age { get; set; }

    }
}