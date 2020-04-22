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
        public int MyProperty { get; set; }

    }
}
