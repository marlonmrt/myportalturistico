using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPServicesTest.TourWS;

namespace SOAPServicesTest
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
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
            DateTime FechaIni = new DateTime(2012, 11, 20);
            DateTime FechaFin = new DateTime(2012, 11, 25);

            //2. Invoca el método a probar del objeto instanciado
            Paquete paq = proxy.CrearPaquete(tp1.CodTipoPaquete, "Paquete de Fin de Semana", FechaIni, FechaFin,8,20,"Un lugar de ensueño a 5 horas de Lima","Cañete","al correo informes@gmail.com",60, 20,0,ag1.CodAgente);

            //busco nuevamente el total de paquetesantes de la inserción
            int total2 = 0;
            foreach (Paquete paquete in proxy.ListarPaquetes())
            {
                total2 += 1;
            }

            //3. Realizar las validaciones de prueba (sobre el resultado)
            Assert.AreEqual(total1 + 1, total2);

             }
             catch (Exception e)
             {
                 Assert.Fail("la fecha de inicio debe ser menor que la fecha de fin");

             }
            
            
        }

       // [TestMethod]
        public void TestCrearPaquete2()
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
                DateTime FechaIni = new DateTime(2012, 11, 25);
                DateTime FechaFin = new DateTime(2012, 11, 20);

                //2. Invoca el método a probar del objeto instanciado
               // Paquete paq = proxy.CrearPaquete(tp1.CodTipoPaquete, "Paquete de Fin de Semana", FechaIni, FechaFin, 8, 20, "Un lugar de ensueño a 5 horas de Lima", "Cañete", "al correo informes@gmail.com", 60, 20, 0, ag1.CodAgente);

                Paquete paq = proxy.CrearPaquete(tp1.CodTipoPaquete, "Semana de Cajamarca", FechaIni, FechaFin, 8, 20, "Un lugar de ensueño a 5 horas de Lima", "Cañete", "al correo informes@gmail.com", 60, 20, 0, ag1.CodAgente);


                //busco nuevamente el total de paquetesantes de la inserción
                int total2 = 0;
                foreach (Paquete paquete in proxy.ListarPaquetes())
                {
                    total2 += 1;
                }

                //3. Realizar las validaciones de prueba (sobre el resultado)
                Assert.AreEqual(total1 + 1, total2);

            }catch(Exception e){
                Assert.Fail("la fecha de inicio debe ser menor que la fecha de fin");
 
            }
            
            

        }
    }
}
