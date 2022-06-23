using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.jrealpec.mscloudexperts.halterofilia.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Deportista = new HashSet<Deportista>();
        }

        [Key]
        [Column("Cod_pais")]
        public int CodPais { get; set; }
        [Column("Nom_Pais")]
        [StringLength(200)]
        public string NomPais { get; set; }

        [InverseProperty("CodPaisNavigation")]
        public virtual ICollection<Deportista> Deportista { get; set; }
    }
}
