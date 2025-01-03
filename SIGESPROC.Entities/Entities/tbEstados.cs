﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEstados
    {
        public tbEstados()
        {
            tbCiudades = new HashSet<tbCiudades>();
        }

        public int esta_Id { get; set; }
        public string esta_Codigo { get; set; }
        public string esta_Nombre { get; set; }
        public int pais_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? esta_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? esta_FechaModificacion { get; set; }

        [NotMapped]
        public int codigo { get; set; }

        [NotMapped]
        public string usuaCreacion { get; set; }

        [NotMapped]
        public string usuaModificacion { get; set; }

        [NotMapped]
        public string pais_Nombre { get; set; }


        public virtual tbPaises pais { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbCiudades> tbCiudades { get; set; }
    }
}