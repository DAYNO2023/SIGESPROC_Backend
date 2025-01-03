﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEquiposSeguridadPorBodegas
    {
        public int eqbo_Id { get; set; }
        public int eqbo_Stock { get; set; }
        public int? bode_Id { get; set; }
        public int? eqpp_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? eqbo_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? eqbo_FechaModificacion { get; set; }
        public bool? eqbo_Estado { get; set; }
        public decimal? eqbo_PrecioCompra { get; set; }

        public virtual tbBodegas bode { get; set; }
        public virtual tbEquiposSeguridadPorProveedores eqpp { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}