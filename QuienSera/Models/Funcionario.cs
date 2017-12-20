using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuienSera.Models
{
    public enum Regimen
    {
        Jornalero,
        Mensual
    }

    public class Funcionario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncionarioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int Padron { get; set; }

        [Required]
        [DisplayName("Cedula de Identidad")]
        public int CI { get; set; }

        [Required]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Regimen? Regimen { get; set; }

        [DisplayName("Foto")]
        public int FotoGIUD { get; set; }

        [DisplayName("Sector")]
        public int SectorID { get; set; }
        public virtual Sector Sector { get; set; }

    }
}