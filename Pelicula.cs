using System;
using System.Collections.Generic;
using System.Text;

namespace OrtFlix
{
    public class Pelicula
    {
        public String nombre { get; set; }
        public TipoAbono abono { get; set; }

        public Pelicula(String nombre, TipoAbono abono)
        {
            this.nombre = nombre;
            this.abono = abono;
        }

        public virtual new string ToString()
        {
            return "Nombre :" + nombre + "Abono :" + abono;
        }

    }
}
