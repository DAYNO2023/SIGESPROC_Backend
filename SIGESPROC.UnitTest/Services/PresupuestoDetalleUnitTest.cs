﻿using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SIGESPROC.API.Extensions;
using SIGESPROC.BusinessLogic;
using SIGESPROC.BusinessLogic.Services.ServiceProyecto;
using SIGESPROC.DataAccess;
using SIGESPROC.DataAccess.Repositories.RepositoryProyecto;
using SIGESPROC.Entities.Entities;
using System;

namespace SIGESPROC.UnitTest.Services
{
    [TestClass]
    public class PresupuestoDetalleUnitTest
    {
        private readonly ProyectoService _proyectoService;
        private readonly IMapper _mapper;
        public Mock<ProyectoRepository> MockProyectoRepository { get; private set; }


        // Mocks adicionales necesarios para BienRaizService
        private Mock<DocumentoRepository> MockDocumentoRepository;
        private Mock<EquipoSeguridadRepository> MockEquipoSeguridadRepository;
        private Mock<EstadoProyectoRepository> MockEstadoProyectoRepository;
        private Mock<EtapaRepository> MockEtapaRepository;
        private Mock<IncidenteRepository> MockIncidenteRepository;
        private Mock<NotificacionAlertaPorUsuarioRepository> MockNotificacionAlertaPorUsuarioRepository;
        private Mock<EtapaPorProyectoRepository> MockEtapaPorProyectoRepository;
        private Mock<GestionAdicionalRepository> MockGestionAdicionalRepository;
        private Mock<GestionRiesgoRepository> MockGestionRiesgoRepository;
        private Mock<ImagenPorControlCalidadRepository> MockImagenPorControlCalidadRepository;
        private Mock<ControlDeCalidadRepository> MockControlDeCalidadRepository;
        private Mock<ControlDeCalidadPorActividadRepository> MockControlDeCalidadPorActividadRepository;
        private Mock<NotificacionRepository> MockNotificacionRepository;
        private Mock<PagoRepository> MockPagoRepository;
        private Mock<RetrasoRepository> MockRetrasoRepository;
        private Mock<InsumoPorActividadRepository> MockInsumoPorActividadRepository;
        private Mock<RentaMaquinariaPorActividadRepository> MockRentaMaquinariaPorActividadRepository;
        private Mock<ActividadPorEtapaRepository> MockActividadPorEtapaRepository;
        private Mock<ArchivoAdjuntoRepository> MockArchivoAdjuntoRepository;
        private Mock<ActividadRepository> MockActividadRepository;
        private Mock<AlertaRepository> MockAlertaRepository;
        private Mock<PresupuestoEncabezadoRepository> MockPresupuestoEncabezadoRepository;
        private Mock<PresupuestoDetalleRepository> MockPresupuestoDetalleRepository;
        private Mock<PresupuestoPorTasaCambioRepository> MockPresupuestoPorTasaCambioRepository;
        private Mock<InsumoPorActividadRepository> MockinsumoPorActividadRepository;
        private Mock<RentaMaquinariaPorActividadRepository> MockrentaMaquinariaPorActividadRepository;
        private Mock<EquipoSeguridadPorActividadRepository> MockEquipoSeguridadPorActividadRepository;
        private Mock<ReferenciasRepository> MockReferenciasRepository;



        public PresupuestoDetalleUnitTest()
        {
            MockProyectoRepository = new Mock<ProyectoRepository>();

            // Crear los mocks necesarios
            MockDocumentoRepository = new Mock<DocumentoRepository>();
            MockEquipoSeguridadRepository = new Mock<EquipoSeguridadRepository>();
            MockEstadoProyectoRepository = new Mock<EstadoProyectoRepository>();
            MockEtapaRepository = new Mock<EtapaRepository>();
            MockIncidenteRepository = new Mock<IncidenteRepository>();
            MockNotificacionAlertaPorUsuarioRepository = new Mock<NotificacionAlertaPorUsuarioRepository>();
            MockEtapaPorProyectoRepository = new Mock<EtapaPorProyectoRepository>();
            MockGestionAdicionalRepository = new Mock<GestionAdicionalRepository>();
            MockGestionRiesgoRepository = new Mock<GestionRiesgoRepository>();
            MockImagenPorControlCalidadRepository = new Mock<ImagenPorControlCalidadRepository>();
            MockControlDeCalidadRepository = new Mock<ControlDeCalidadRepository>();
            MockControlDeCalidadPorActividadRepository = new Mock<ControlDeCalidadPorActividadRepository>();
            MockNotificacionRepository = new Mock<NotificacionRepository>();
            MockPagoRepository = new Mock<PagoRepository>();
            MockRetrasoRepository = new Mock<RetrasoRepository>();
            MockInsumoPorActividadRepository = new Mock<InsumoPorActividadRepository>();
            MockRentaMaquinariaPorActividadRepository = new Mock<RentaMaquinariaPorActividadRepository>();
            MockActividadPorEtapaRepository = new Mock<ActividadPorEtapaRepository>();
            MockArchivoAdjuntoRepository = new Mock<ArchivoAdjuntoRepository>();
            MockActividadRepository = new Mock<ActividadRepository>();
            MockAlertaRepository = new Mock<AlertaRepository>();
            MockPresupuestoEncabezadoRepository = new Mock<PresupuestoEncabezadoRepository>();
            MockPresupuestoDetalleRepository = new Mock<PresupuestoDetalleRepository>();
            MockPresupuestoPorTasaCambioRepository = new Mock<PresupuestoPorTasaCambioRepository>();
            MockinsumoPorActividadRepository = new Mock<InsumoPorActividadRepository>();
            MockrentaMaquinariaPorActividadRepository = new Mock<RentaMaquinariaPorActividadRepository>();
            MockEquipoSeguridadPorActividadRepository = new Mock<EquipoSeguridadPorActividadRepository>();
            MockReferenciasRepository = new Mock<ReferenciasRepository>();


            // Configuración de AutoMapper
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfileExtensions());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }



            _proyectoService = new ProyectoService(
                MockDocumentoRepository.Object,
                MockEquipoSeguridadRepository.Object,
                MockEstadoProyectoRepository.Object,
                MockEtapaRepository.Object,
                MockIncidenteRepository.Object,
                MockNotificacionAlertaPorUsuarioRepository.Object,
                MockEtapaPorProyectoRepository.Object,
                MockGestionAdicionalRepository.Object,
                MockGestionRiesgoRepository.Object,
                MockImagenPorControlCalidadRepository.Object,
                MockControlDeCalidadRepository.Object,
                MockControlDeCalidadPorActividadRepository.Object,
                MockNotificacionRepository.Object,
                MockPagoRepository.Object,
                MockRetrasoRepository.Object,
                MockInsumoPorActividadRepository.Object,
                MockRentaMaquinariaPorActividadRepository.Object,
                MockActividadPorEtapaRepository.Object,
                MockArchivoAdjuntoRepository.Object,
                MockActividadRepository.Object,
                MockAlertaRepository.Object,
                MockPresupuestoEncabezadoRepository.Object,
                MockPresupuestoDetalleRepository.Object,
                MockPresupuestoPorTasaCambioRepository.Object,
                MockProyectoRepository.Object,
                MockinsumoPorActividadRepository.Object,
                MockrentaMaquinariaPorActividadRepository.Object,
                MockEquipoSeguridadPorActividadRepository.Object,
                MockReferenciasRepository.Object
                );
        }
        //protected Mock<IMapper> map = new Mock<IMapper>();


        [TestMethod]
        public void PresupuestoDetalleCreate()
        {
            var modelo = new tbPresupuestosDetalle()
            {
                pdet_Id = 1139,
                pdet_Cantidad = 1,
                pdet_PrecioManoObra = 120,
                pdet_PrecioMateriales = 0,
                pdet_PrecioMaquinaria = 0,
                pdet_MaquinariaFormula = "",
                pdet_MaterialFormula = "",
                pdet_ManoObraFormula = "",
                pdet_CantidadFormula = "",
                unme_Id = 58,
                pren_Id = 146,
                acet_Id = 2316,
                pdet_Incluido = false,
                pdet_Ganancia = 0,
                acti_Id = 0,
                usua_Creacion = 56,
                pdet_FechaCreacion = DateTime.Now,
                usua_Modificacion = 56,
                pdet_FechaModificacion = DateTime.Now
            };

            MockPresupuestoDetalleRepository.Setup(pr => pr.Insert(It.IsAny<tbPresupuestosDetalle>()))
              .Returns(new RequestStatus { CodeStatus = 1, MessageStatus = "Exito" });

            var result = _proyectoService.InsertarPresupuestoDetalle(modelo);

            Assert.IsInstanceOfType<ServiceResult>(result);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PresupuestoDetalleUpdate()
        {
            var modelo = new tbPresupuestosDetalle()
            {
                pdet_Id = 1139,
                pdet_Cantidad = 1,
                pdet_PrecioManoObra = 120,
                pdet_PrecioMateriales = 0,
                pdet_PrecioMaquinaria = 0,
                pdet_MaquinariaFormula = "",
                pdet_MaterialFormula = "",
                pdet_ManoObraFormula = "",
                pdet_CantidadFormula = "",
                unme_Id = 58,
                pren_Id = 146,
                acet_Id = 2316,
                pdet_Incluido = false,
                pdet_Ganancia = 0,
                acti_Id = 0,
                usua_Creacion = 56,
                pdet_FechaCreacion = DateTime.Now,
                usua_Modificacion = 56,
                pdet_FechaModificacion = DateTime.Now
            };
            MockPresupuestoDetalleRepository.Setup(pr => pr.Update(It.IsAny<tbPresupuestosDetalle>()))
           .Returns(new RequestStatus { CodeStatus = 1, MessageStatus = "Exito" });

            var result = _proyectoService.ActualizarPresupuestosDetalle(modelo);

            Assert.IsInstanceOfType<ServiceResult>(result);
            Assert.IsNotNull(result);
        }
    }
}
