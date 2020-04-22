using System;
using System.Collections.Generic;
using System.Text;

namespace ExpoCarreras.Datos.Entidades
{
    public class Domicilio
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Nro { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Barrio { get; set; }
        public Localidad Localidad { get; set; }
    }
}
