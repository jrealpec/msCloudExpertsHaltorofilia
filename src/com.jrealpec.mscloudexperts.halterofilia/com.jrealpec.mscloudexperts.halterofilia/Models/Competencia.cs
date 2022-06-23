using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.jrealpec.mscloudexperts.halterofilia.Models
{
    [Table("Competencia")]
    public class Competencia
    {

        [Key]
        [Column("Cod_Competencia")]
        public int CodCompetencia { get; set; }
        [Column("Etapa")]
        public int Etapa { get; set; }
        [Column("Cod_Deportista")]
        public int CodDeportista { get; set; }
        [Column("Cod_Modalidad")]
        public int CodModalidad { get; set; }
        public int Cantidad { get; set; }
        [Column("Cod_Pais")]
        public int CodPais {get; set;}
        public string Nom_Pais { get; set; }
        public string Nom_Deportista { get; set; }

        public string Nom_Modalidad { get; set; }

        [ForeignKey(nameof(CodDeportista))]
        [InverseProperty(nameof(Deportista.Competencia))]
        public virtual Deportista CodDeportistaNavigation { get; set; }
        [ForeignKey(nameof(CodModalidad))]
        [InverseProperty(nameof(Modalidad.Competencia))]
        public virtual Modalidad CodModalidadNavigation { get; set; }
    }
}
