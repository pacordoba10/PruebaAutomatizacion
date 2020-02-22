using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PruebaAutomatizacion.Clases
{
    class MetodosAutomatizar
    {
        public void busquedaCargoEmpleos()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.choucairtesting.com/empleos-testing/");
            IWebElement input = driver.FindElement(By.Id("search_keywords")); // BUSCA ELEMENTO CARGO
            IWebElement botonbuscar = driver.FindElement(By.ClassName("search_submit")); // BUSCA ELEMENTO BOTON BUSCAR TRABAJOS

            driver.Manage().Window.Maximize();

            input.SendKeys("Analista");
            botonbuscar.Click();
            Console.WriteLine("Realizado");
        }

        public void BusquedaUbicacion()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.choucairtesting.com/empleos-testing/");

            driver.Manage().Window.Maximize();
            IWebElement input = driver.FindElement(By.Id("search_location"));// BUSCA ELEMENTO UBICACION
            IWebElement botonbuscar = driver.FindElement(By.ClassName("search_submit")); // BUSCA ELEMENTO BOTON BUSCAR TRABAJOS

            input.SendKeys("Medellin");
            botonbuscar.Click();

            Console.WriteLine("Realizado");

        }

        public void BusquedaCargoyUbicacion()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.choucairtesting.com/empleos-testing/");

            driver.Manage().Window.Maximize();
            IWebElement inputl = driver.FindElement(By.Id("search_location"));
            IWebElement inputk = driver.FindElement(By.Id("search_keywords"));
            IWebElement botonbuscar = driver.FindElement(By.ClassName("search_submit")); // BUSCA ELEMENTO BOTON BUSCAR TRABAJOS

            inputl.SendKeys("Bogotá");
            inputk.SendKeys("Psicólogo de selección");
            botonbuscar.Click();
            Console.WriteLine("Realizado");
        }

        public void abrirModeloCalidadSof()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.choucairtesting.com/empleos-testing/");
            driver.Manage().Window.Maximize();

            Console.WriteLine("Cargo pagina");

            IWebElement calidadSoftwate = driver.FindElement(By.LinkText("Modelo de calidad de software"));
            string a = calidadSoftwate.GetAttribute("href");

            bool b;

            try
            {
                
                driver.Navigate().GoToUrl(a);
                b = true;
            }
            catch (Exception ex)
            {
                b = false;
            }

            string pag = driver.Url;
            if (pag == a)
            {
                Console.WriteLine("Pagina correcta");
            }
            else
            {
                Console.WriteLine("Pagina error");
            }

            Console.WriteLine("Cargo Contactenos");

        }
    }
}
