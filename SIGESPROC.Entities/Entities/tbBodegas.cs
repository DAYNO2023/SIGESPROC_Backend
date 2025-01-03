﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbBodegas
    {
        public tbBodegas()
        {
            tbBodegasPorInsumo = new HashSet<tbBodegasPorInsumo>();
            tbEquiposSeguridadPorBodegas = new HashSet<tbEquiposSeguridadPorBodegas>();
        }

        public int bode_Id { get; set; }
        public string bode_Descripcion { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime bode_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? bode_FechaModificiacion { get; set; }
        public bool? bode_Estado { get; set; }
        public string bode_Latitud { get; set; }
        public string bode_Longitud { get; set; }
        public string bode_LinkUbicacion { get; set; }

        [NotMapped]
        public int codigo { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }


        [NotMapped]
        public int id { get; set; }

        [NotMapped]
        public int insumoId { get; set; }

        [NotMapped]
        public string articulo { get; set; }

        [NotMapped]
        public decimal precio { get; set; }

        [NotMapped]
        public DateTime fechaCreacion { get; set; }

        [NotMapped]
        public string categoria { get; set; }

        [NotMapped]
        public int unidad { get; set; }

        [NotMapped]
        public string medida { get; set; }

        [NotMapped]
        public decimal stock { get; set; }

        [NotMapped]
        public decimal precioEnBodega { get; set; }

        [NotMapped]
        public bool agregadoABodega { get; set; }

        [NotMapped]
        public int bopi_Id { get; set; }

        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbBodegasPorInsumo> tbBodegasPorInsumo { get; set; }
        public virtual ICollection<tbEquiposSeguridadPorBodegas> tbEquiposSeguridadPorBodegas { get; set; }
    }
}