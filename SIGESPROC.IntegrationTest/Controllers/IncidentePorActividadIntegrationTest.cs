﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIGESPROC.IntegrationTest.Mocks;
using SIGESPROC.IntegrationTests;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SIGESPROC.IntegrationTest.Controllers
{
    [TestClass]
    public class IncidentePorActividadIntegrationTest : DbContextMocker
    {

         private const string ApiKey = "4b567cb1c6b24b51ab55248f8e66e5cc";

        [TestMethod]
        public async Task IncidentePorActividadActualizar()
        {

            //creamos el cliente
            var cliente = factory.CreateClient();

            //añadimos la apikey al header
            cliente.DefaultRequestHeaders.Add("XApiKey", ApiKey);

            var mock = IncidentePorActividadMock.ActualizarIncidentePorActividadMock();


            // Serializa el objeto a JSON para enviarlo en el cuerpo de la peticion
            var contenido = new StringContent(System.Text.Json.JsonSerializer.Serialize(mock), System.Text.Encoding.UTF8, "application/json");
            Console.WriteLine(contenido);

            var response = await cliente.PutAsync("https://localhost:44337/api/IncidentePorActividad/Actualizar", contenido);
            response.EnsureSuccessStatusCode();

            //Aserciones
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.IsNotNull(response);

            // Lee el contenido de la respuesta 
            var responseContent = await response.Content.ReadAsStringAsync();
            Assert.IsFalse(string.IsNullOrEmpty(responseContent));
        }


        [TestMethod]
        public async Task IncidentePorActividadInsertar()
        {
            //creamos el cliente
            var cliente = factory.CreateClient();

            //añadimos la apikey al header
            cliente.DefaultRequestHeaders.Add("XApiKey", ApiKey);

            var mock = IncidentePorActividadMock.InsertarIncidentePorActividadMock();

            // Serializa el objeto a JSON para enviarlo en el cuerpo de la peticion
            var contenido = new StringContent(System.Text.Json.JsonSerializer.Serialize(mock), System.Text.Encoding.UTF8, "application/json");

            // Aquí hace la petición a la URL tipo Post
            var response = await cliente.PostAsync("https://localhost:44337/api/IncidentePorActividad/Insertar", contenido);

            // Verifica si la respuesta fue exitosa
            if (!response.IsSuccessStatusCode)
            {
                // Lee el contenido del error para depurar
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorContent}");
            }

            // Aserciones
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode, "La respuesta no fue exitosa");
            Assert.IsNotNull(response);

            // Lee el contenido de la respuesta 
            var responseContent = await response.Content.ReadAsStringAsync();
            Assert.IsFalse(string.IsNullOrEmpty(responseContent));
        }
    }
}
