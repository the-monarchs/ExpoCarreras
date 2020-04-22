using System;
using System.Collections.Generic;
using System.Text;

namespace ExpoCarreras.Datos.Entidades
{
    public class OfertaAcademica
    {
        public int Id { get; set; }

        public int IdTipoOfertaAcademica { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Institucion Institucion { get; set; }
        public float Duracion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime FechaAlta { get; set; }


    }
}
