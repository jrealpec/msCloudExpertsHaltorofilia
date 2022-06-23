using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.jrealpec.mscloudexperts.halterofilia.Models
{
    public partial class Modalidad
    {
        public Modalidad()
        {
            Competencia = new HashSet<Competencia>();
        }

        [Key]
        [Column("Cod_Modalidad")]
        public int CodModalidad { get; set; }
        [Column("Nom_modalidad")]
        [StringLength(250)]
        public string NomModalidad { get; set; }

        [InverseProperty("CodModalidadNavigation")]
        public virtual ICollection<Competencia> Competencia { get; set; }
    }
}
