﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESPROC.Common.Models.ModelsInsumo
{
    public class CotizacionDetalleViewModel
    {
        public int code_Cantidad { get; set; }
        public int code_Renta { get; set; }

        public bool coti_Incluido { get; set; }

        public decimal code_PrecioCompra { get; set; }
        public int cime_Id { get; set; }

        public int cime_InsumoOMaquinariaOEquipoSeguridad { get; set; }
        public int coti_Id { get; set; }

        public bool coti_CompraDirecta { get; set; }
        public bool check { get; set; }
        public int? prov_Id { get; set; }
        public int code_Id { get; set; }
        public int? inpp_Id { get; set; }
        public int? unme_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime code_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? code_FechaModificacion { get; set; }

    }
}