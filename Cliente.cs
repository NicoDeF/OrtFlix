using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OrtFlix
{
    public class Cliente
    {
        public String dni { get; set; }
        public TipoAbono abono { get; set; }
        private List<Pelicula> peliculas;
        private List<CapituloSerie> series;

        public Cliente(String dni, TipoAbono abono)
        {
            this.dni = dni;
            this.abono = abono;
            peliculas = new List<Pelicula>();
            series = new List<CapituloSerie>();
        }

        public double ObtenerSaldo()
        {
            double saldo = 0;
            return saldo;
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void AgregarSerie(CapituloSerie serie)
        {
            series.Add(serie);
        }

        



    }
}
