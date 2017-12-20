using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuienSera.Models
{
    public class Sector
    {
        public int SectorID { get; set; }
        public string Nombre { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}