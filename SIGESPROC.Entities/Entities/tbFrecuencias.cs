﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbFrecuencias
    {
        public tbFrecuencias()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
            tbPlanillas = new HashSet<tbPlanillas>();
            tbPrestamos = new HashSet<tbPrestamos>();
        }

        public int frec_Id { get; set; }
        public string frec_Descripcion { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime frec_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? frec_FechaModificacion { get; set; }
        public bool? frec_Estado { get; set; }
        public string frec_NumeroDias { get; set; }

        [NotMapped]
        public int codigo { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }

        [NotMapped]
        public string frecuencia { get; set; }

        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbPlanillas> tbPlanillas { get; set; }
        public virtual ICollection<tbPrestamos> tbPrestamos { get; set; }
    }
}