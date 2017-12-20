using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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


        [Required]
        public int FuncionarioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [DisplayName("Nombre Completo")]
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        [Required]
        public int Padron { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public Int64 CI { get; set; }

        [Required]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Regimen? Regimen { get; set; }

        [DisplayName("Foto")]
        public int FotoGIUD { get; set; }

        [DisplayName("Sector")]
        public Sector Sector { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int SectorID { get; set; }

        [DisplayName("Funcionarios Referidos")]
        public List<Funcionario> Referidos { get; set; }

    }
}