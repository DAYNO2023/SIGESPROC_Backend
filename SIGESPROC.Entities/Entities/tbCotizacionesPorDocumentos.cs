﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbCotizacionesPorDocumentos
    {
        public int copd_Id { get; set; }
        public int coti_Id { get; set; }
        public string copd_Documento { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime copd_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? copd_FechaModificacion { get; set; }
        public string copd_Descripcion { get; set; }

        public virtual tbCotizaciones coti { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
    }
}