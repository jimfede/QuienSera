using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuienSera.Models
{
    public class Sector
    {
        [Key]
        public int SectorID { get; set; }
        [DisplayName("Nombre de Sector")]
        public string Nombre { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}