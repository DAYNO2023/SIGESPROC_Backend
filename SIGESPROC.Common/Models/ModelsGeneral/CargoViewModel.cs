﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESPROC.Common.Models.ModelsGeneral
{
    public class CargoViewModel
    {
        //NOTMAPPED
        [NotMapped]
        public int codigo { get; set; }

        [NotMapped]
        public string usuaCreacion { get; set; }

        [NotMapped]
        public string usuaModificacion { get; set; }

        //END NOTMAPPED
        public int carg_Id { get; set; }
        public string carg_Descripcion { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime carg_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? carg_FechaModificacion { get; set; }
        public bool? carg_Estado { get; set; }
    }
}