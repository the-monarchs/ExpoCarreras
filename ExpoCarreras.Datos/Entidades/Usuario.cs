using System;
using System.Collections.Generic;
using System.Text;

namespace ExpoCarreras.Datos.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaAlta { get; set; }
        public Persona Persona { get; set; }
    }
}
