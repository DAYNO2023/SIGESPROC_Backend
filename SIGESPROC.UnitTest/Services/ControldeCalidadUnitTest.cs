﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SIGESPROC.BusinessLogic;
using SIGESPROC.BusinessLogic.Services.ServiceProyecto;
using SIGESPROC.DataAccess;
using SIGESPROC.DataAccess.Repositories.RepositoryProyecto;
using SIGESPROC.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGESPROC.UnitTest.Services
{
    [TestClass]
    public class ControldeCalidadUnitTest
    {
        private readonly ProyectoService _proyectoService;
        public Mock<ControlDeCalidadRepository> MockControldeCalidadRepository { get; private set; }

        public ControldeCalidadUnitTest()
        {
            MockControldeCalidadRepository = new Mock<ControlDeCalidadRepository>();

            _proyectoService = new ProyectoService(
                new Mock<DocumentoRepository>().Object,
                new Mock<EquipoSeguridadRepository>().Object,
                new Mock<EstadoProyectoRepository>().Object,
                new Mock<EtapaRepository>().Object,
                new Mock<IncidenteRepository>().Object,
                new Mock<NotificacionAlertaPorUsuarioRepository>().Object,
                new Mock<EtapaPorProyectoRepository>().Object,
                new Mock<GestionAdicionalRepository>().Object,
                new Mock<GestionRiesgoRepository>().Object,
                new Mock<ImagenPorControlCalidadRepository>().Object,
                MockControldeCalidadRepository.Object,
                new Mock<ControlDeCalidadPorActividadRepository>().Object,
                new Mock<NotificacionRepository>().Object,
                new Mock<PagoRepository>().Object,
                new Mock<RetrasoRepository>().Object,
                new Mock<InsumoPorActividadRepository>().Object,
                new Mock<RentaMaquinariaPorActividadRepository>().Object,
                new Mock<ActividadPorEtapaRepository>().Object,
                new Mock<ArchivoAdjuntoRepository>().Object,
                new Mock<ActividadRepository>().Object,
                new Mock<AlertaRepository>().Object,
                new Mock<PresupuestoEncabezadoRepository>().Object,
                new Mock<PresupuestoDetalleRepository>().Object,
                new Mock<PresupuestoPorTasaCambioRepository>().Object,
                new Mock<ProyectoRepository>().Object,
                new Mock<InsumoPorActividadRepository>().Object,
                new Mock<RentaMaquinariaPorActividadRepository>().Object,
                new Mock<EquipoSeguridadPorActividadRepository>().Object,
                new Mock<ReferenciasRepository>().Object
            );
        }


        [TestMethod]
        public void ControldeCalidadCreateTest()
        {
            MockControldeCalidadRepository.Setup(repo => repo.Insert(It.IsAny<tbControlDeCalidadesPorActividades>()))
                .Returns(new RequestStatus { CodeStatus = 1, MessageStatus = "Éxito" });

            var result = _proyectoService.InsertarControlDeCalidadPorActividad(It.IsAny<tbControlDeCalidadesPorActividades>());

            Assert.IsInstanceOfType(result, typeof(ServiceResult));
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void ControldeCalidadUpdateTest()
        //{
        //    MockControldeCalidadRepository.Setup(repo => repo.Update1(It.IsAny<tbControlDeCalidadesPorActividades>()))
        //        .Returns(new RequestStatus { CodeStatus = 1, MessageStatus = "Actualización Exitosa" });

        //    var result = _proyectoService.ActualizarControlDeCalidadPorActividad(It.IsAny<tbControlDeCalidadesPorActividades>());

        //    Assert.IsInstanceOfType(result, typeof(ServiceResult));
        //    Assert.IsNotNull(result);
        //}

    }
}
