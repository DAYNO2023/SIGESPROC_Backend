﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbImagenesPorControlesDeCalidades
    {
        [NotMapped]
        public int codigo { get; set; }
        public int icca_Id { get; set; }
        public string icca_Imagen { get; set; }
        public string icca_Descripcion { get; set; }
        public int? coac_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime icca_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? icca_FechaModificacion { get; set; }
        public bool? icca_Estado { get; set; }

        public int? coca_Id { get; set; }

        public virtual tbControlDeCalidadesPorActividades coca { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}