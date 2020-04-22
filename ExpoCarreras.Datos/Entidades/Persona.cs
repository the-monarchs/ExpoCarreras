using System;
using System.Collections.Generic;
using System.Text;

namespace ExpoCarreras.Datos.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int  Genero { get; set; }
        public Domicilio Domicilio { get; set; }
    }
}
