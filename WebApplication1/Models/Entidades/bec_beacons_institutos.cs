using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;



namespace WebApplication1.Models.Entidades
{
    [Table("bec_beacons_institutos")]
    public class bec_beacons_institutos
    {
        [Key]
        [Required]
        public Int16 IdInstituto { get; set; }
        [ForeignKey("bec_cat_beacons")]
        public int IdBeacon { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        public Nullable<DateTime> FechaReg { get; set; }
        [StringLength(20)]
        public string UsuarioReg { get; set; }
        public Nullable<DateTime> FechaUltMod { get; set; }
        [StringLength(20)]
        public string UsuarioMod { get; set; }
        [StringLength(1)]
        public string Borrado { get; set; }
       



    }
}

