﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbDocumentos
    {
        public int docu_Id { get; set; }
        public string docu_Tipo { get; set; }
        public string docu_Descripcion { get; set; }
        public string docu_Ruta { get; set; }
        public DateTime docu_Fecha { get; set; }
        public int? empl_Id { get; set; }
        public int proy_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime docu_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? docu_FechaModificacion { get; set; }
        public bool? docu_Estado { get; set; }

        [NotMapped]
        public string proy_Nombre { get; set; }
        [NotMapped]
        public string empl_NombreCompleto { get; set; }
        [NotMapped]
        public string docu_TipoDescripcion { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }
        [NotMapped]
        public int row { get; set; }

        public virtual tbEmpleados empl { get; set; }
        public virtual tbProyectos proy { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}