using System;
using System.Collections.Generic;
using System.Text;

namespace ExpoCarreras.Datos.Entidades
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Provincia Provincia { get; set; }
    }
}
