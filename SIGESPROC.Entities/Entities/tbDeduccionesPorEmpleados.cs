﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbDeduccionesPorEmpleados
    {
        public int deem_Id { get; set; }
        public int dedu_Id { get; set; }
        public int empl_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime deem_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? deem_FechaModificacion { get; set; }
        public decimal? deem_Porcentaje { get; set; }
        public bool? deem_EsMontoFijo { get; set; }

        public virtual tbDeducciones dedu { get; set; }
        public virtual tbEmpleados empl { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}