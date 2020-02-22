using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using PruebaAutomatizacion.Clases;

namespace PruebaAutomatizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosAutomatizar mt = new MetodosAutomatizar();

            mt.busquedaCargoEmpleos();
            mt.BusquedaUbicacion();
            mt.BusquedaCargoyUbicacion();
            mt.abrirModeloCalidadSof();
                        

        }
    }
}
