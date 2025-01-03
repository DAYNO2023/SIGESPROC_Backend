﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEquiposSeguridadPorProveedores
    {
        public tbEquiposSeguridadPorProveedores()
        {
            tbEquiposSeguridadPorActividades = new HashSet<tbEquiposSeguridadPorActividades>();
            tbEquiposSeguridadPorBodegas = new HashSet<tbEquiposSeguridadPorBodegas>();
        }

        public int eqpp_Id { get; set; }
        public int? equs_Id { get; set; }
        public int? prov_Id { get; set; }
        public decimal eqpp_PrecioCompra { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime eqpp_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? eqpp_FechaModificacion { get; set; }

        [NotMapped]
        public string equs_Nombre { get; set; }
        [NotMapped]
        public string equs_Descripcion { get; set; }
        [NotMapped]
        public string prov_Descripcion { get; set; }
        [NotMapped]
        public int eqbo_Stock { get; set; }
        [NotMapped]
        public int bode_Id { get; set; }
        [NotMapped]
        public string bode_Descripcion { get; set; }
        [NotMapped]
        public int eqac_Cantidad { get; set; }
        [NotMapped]
        public decimal eqac_Costo { get; set; }


        public virtual tbEquiposSeguridad equs { get; set; }
        public virtual tbProveedores prov { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbEquiposSeguridadPorActividades> tbEquiposSeguridadPorActividades { get; set; }
        public virtual ICollection<tbEquiposSeguridadPorBodegas> tbEquiposSeguridadPorBodegas { get; set; }
    }
}