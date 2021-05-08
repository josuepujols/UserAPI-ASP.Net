using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string password { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string correo { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int estado { get; set; }
    }
}
