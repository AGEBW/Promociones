using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Entidades
{
    [Table("bec_institutos_promociones")]
     public class bec_institutos_promociones
        {
            [Key]
            [Required]
            public int IdPromocion { get; set; }
            [ForeignKey("bec_beacons_institutos")]
            public Int16 IdInstituto { get; set; }
            [ForeignKey("bec_beacons_institutos")]
            public int IdBeacon { get; set; }
            [StringLength(500)]
            public string DesPromocion { get; set; }
            public Nullable<DateTime> FechaHoraIni { get; set; }
            public Nullable<DateTime> FechaHoraFin { get; set; }
            public Nullable<DateTime> FechaReg { get; set; }
            [StringLength(1)]
            public string Activo { get; set; }
            [StringLength(20)]
            public string ImagenUrl { get; set; }
            [StringLength(1)]
            public string ImagenBLOB { get; set; }
            public Nullable<DateTime> FechaUltMod { get; set; }
            [StringLength(20)]
            public string UsuarioReg { get; set; }
            [StringLength(20)]
            public string UsuarioMod { get; set; }
            [StringLength(1)]
            public string Borrado { get; set; }
            [StringLength(20)]
            public string ImagenLocal { get; set; }



        }
}
