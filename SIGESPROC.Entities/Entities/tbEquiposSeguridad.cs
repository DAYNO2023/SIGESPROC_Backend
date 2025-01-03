﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEquiposSeguridad
    {
        public tbEquiposSeguridad()
        {
            tbEquiposSeguridadPorProveedores = new HashSet<tbEquiposSeguridadPorProveedores>();
        }

        [NotMapped]
        public decimal equs_UltimoPrecio { get; set; }

        public int equs_Id { get; set; }
        public string equs_Nombre { get; set; }
        public string equs_Descripcion { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? equs_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? equs_FechaModificacion { get; set; }
        public bool? equs_Estado { get; set; }

        [NotMapped]
        public string UsuaModificacion { get; set; }

        [NotMapped]
        public string estado { get; set; }
        [NotMapped]
        public string UsuaCreacion { get; set; }

        [NotMapped]
        public int codigo { get; set; }

        [NotMapped]
        public int eqpp_Id { get; set; }
        [NotMapped]
        public int bode_Id { get; set; }
        [NotMapped]
        public string bode_Descripcion { get; set; }
        [NotMapped]
        public int bopi_Stock { get; set; }
        [NotMapped]
        public int prov_Id { get; set; }
        [NotMapped]
        public string prov_Descripcion { get; set; }
        [NotMapped]
        public double eqpp_PrecioCompra { get; set; }

        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbEquiposSeguridadPorProveedores> tbEquiposSeguridadPorProveedores { get; set; }
    }
}