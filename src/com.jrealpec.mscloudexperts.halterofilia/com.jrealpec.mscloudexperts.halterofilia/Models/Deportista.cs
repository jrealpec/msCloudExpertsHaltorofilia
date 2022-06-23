using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.jrealpec.mscloudexperts.halterofilia.Models
{
    public class Deportista
    {
        public Deportista()
        {
            Competencia = new HashSet<Competencia>();
        }

        [Key]
        [Column("Cod_Deportista")]
        public int CodDeportista { get; set; }
        [Required]
        [Column("Nom_Deportista")]
        [StringLength(250)]
        public string NomDeportista { get; set; }
        [Column("Cod_pais")]
        public int CodPais { get; set; }

        [ForeignKey(nameof(CodPais))]
        [InverseProperty(nameof(Pais.Deportista))]
        public virtual Pais CodPaisNavigation { get; set; }
        [InverseProperty("CodDeportistaNavigation")]
        public virtual ICollection<Competencia> Competencia { get; set; }
    }
}
