using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPServicesTest.TourWS;
using System.ServiceModel;

namespace SOAPServicesTest
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        
        //[TestMethod]

        //crea bien el paquete
        public void TestCrearPaquete1()
        {
            try {
            
            //1. Instancia el objeto a probar
            TourWS.TourServiceClient proxy = new TourWS.TourServiceClient();
            
            //obtengo un tipo paquete
            TipoPaquete tp1 = proxy.ObtenerTipoPaquete(1);
            //obtengo un agente
            Agente ag1 = proxy.ObtenerAgente(1);

            //busco el total de paquetesantes de la inserción
            int total1 = 0;
            foreach (Paquete paquete in proxy.ListarPaquetes())
            {
                total1 += 1;
            }
            //creo paquete
            DateTime FechaIni = new DateTime(2012, 12, 20);
            DateTime FechaFin = new DateTime(2012, 12, 25);

            //2. Invoca el método a probar del objeto instanciado
            Paquete paq = proxy.CrearPaquete(tp1.CodTipoPaquete, "Paquete de año nuevo IIII", FechaIni, FechaFin,8,20,"Un lugar de ensueño a 5 horas de Lima","Cañete","al correo informes@gmail.com",60, 20,0,ag1.CodAgente);

            //busco nuevamente el total de paquetesantes de la inserción
            int total2 = 0;
            foreach (Paquete paquete in proxy.ListarPaquetes())
            {
                total2 += 1;
            }

            //3. Realizar las validaciones de prueba (sobre el resultado)
            Assert.AreEqual(total1 + 1, total2);

            }
            catch (FaultException<TourWS.Error> faultEx)
            {
                Assert.AreEqual("La hora de fin no puede ser menor que la del inicio", faultEx.Detail.MensajeNegocio);

            }
            catch (Exception e)
            {

                Assert.AreEqual("Error general", e.Message);
            }
            
        }

               
        //prueba el ingrseo de hora inicio mayor que hora final
        //[TestMethod]
        public void TestProbarHorasCrearPaquete()
        {

            try {
                //1. Instancia el objeto a probar
                TourWS.TourServiceClient proxy = new TourWS.TourServiceClient();

                //obtengo un tipo paquete
                TipoPaquete tp1 = proxy.ObtenerTipoPaquete(1);
                //obtengo un agente
                Agente ag1 = proxy.ObtenerAgente(1);

                //busco el total de paquetesantes de la inserción
                int total1 = 0;
                foreach (Paquete paquete in proxy.ListarPaquetes())
                {
                    total1 += 1;
                }
                
                DateTime FechaIni = new DateTime(2012, 11, 10);
                DateTime FechaFin = new DateTime(2012, 11, 20);
                //creo paquete
                Paquete paq = proxy.CrearPaquete(tp1.CodTipoPaquete, "Semana de Cajamarca", FechaIni, FechaFin, 14, 8, "Un lugar de ensueño a 5 horas de Lima", "Cañete", "al correo informes@gmail.com", 60, 20, 0, ag1.CodAgente);


                //busco nuevamente el total de paquetesantes de la inserción
                int total2 = 0;
                foreach (Paquete paquete in proxy.ListarPaquetes())
                {
                    total2 += 1;
                }

                //3. Realizar las validaciones de prueba (sobre el resultado)
                Assert.AreEqual(total1 + 1, total2);
            }
            catch (FaultException<TourWS.Error> faultEx)
            {
                Assert.AreEqual("La hora de fin no puede ser menor que la del inicio", faultEx.Detail.MensajeNegocio);
             
            }catch(Exception e){

                Assert.AreEqual("Operación inválida", e.Message);
            }

        }

        //prueba el ingreso de hora inicio mayor que hora final
        [TestMethod]
        public void TestProbarHorasModificarPaquete()
        {

            try
            {
                //1. Instancia el objeto a probar
                TourWS.TourServiceClient proxy = new TourWS.TourServiceClient();

                //obtengo un tipo paquete
                TipoPaquete tp1 = proxy.ObtenerTipoPaquete(1);
                //obtengo un agente
                Agente ag1 = proxy.ObtenerAgente(1);

                int codigoPaquete = 1;
                int horaInicio = 14;  //las 2 de la tarde
                int horaFinal = 8;  //las 8 de la mañana
                DateTime FechaIni = new DateTime(2012, 11, 10);
                DateTime FechaFin = new DateTime(2012, 11, 20);
                //modifico paquete
                Paquete paq = proxy.ModificarPaquete(codigoPaquete, tp1.CodTipoPaquete, "Semana de Cajamarca", FechaIni, FechaFin, horaInicio, horaFinal, "Un lugar de ensueño al sur de Ica", "Cañete", "al correo julio@gmail.com", 60, 20, 0, ag1.CodAgente);

                //obtengo paquete
                Paquete paqObtenido = proxy.ObtenerPaquete(codigoPaquete);
                //3. Realizar las validaciones de prueba (sobre el resultado)

                Assert.AreEqual(paqObtenido.NombrePaquete, "Semana de Cajamarca");
                Assert.AreEqual(paqObtenido.FechaInicio, FechaIni);
                Assert.AreEqual(paqObtenido.FechaFin, FechaFin);
            }
            catch (FaultException<TourWS.Error> faultEx)
            {
                Assert.AreEqual("La hora de fin no puede ser menor que la del inicio", faultEx.Detail.MensajeNegocio);

            }
            catch (Exception e)
            {

                Assert.AreEqual("Operación inválida", e.Message);
            }

        }
         
    }
}
