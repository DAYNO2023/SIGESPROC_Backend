﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbPlanillaDetalles_Bitacora
    {
        public int plde_Id { get; set; }
        public decimal plde_SueldoBruto { get; set; }
        public decimal plde_TotalDeducciones { get; set; }
        public decimal? plde_TotalPrestamos { get; set; }
        public decimal plde_SueldoNeto { get; set; }
        public int empl_Id { get; set; }
        public int plan_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime? plde_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? plde_FechaModificacion { get; set; }
        public string accion { get; set; }
    }
}