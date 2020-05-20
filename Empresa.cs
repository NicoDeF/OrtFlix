using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrtFlix
{
    public class Empresa
    {
        private String nombre { get; set; }

        private List<Pelicula> peliculas;
        private List<CapituloSerie> series;
        private List<Cliente> clientes;

        public Empresa(String nombre)
        {
            this.nombre = nombre;
            peliculas = new List<Pelicula>();
            series = new List<CapituloSerie>();
            clientes = new List<Cliente>();
        }
        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void AgregarSerie(CapituloSerie serie)
        {
            series.Add(serie);
        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public ResultadoAlquiler verSerie(String dni, String nombre)
        {
            Cliente cliente = buscarCliente(dni);
            CapituloSerie serie = buscarSerie(nombre);
            return verSerie(cliente, serie);
        }

        private CapituloSerie buscarSerie(string nombre)
        {
            CapituloSerie serie_ok = null, serie;
            int i = 0;

            while (i < series.Count() && serie_ok == null)
            {
                serie = series.BinarySearch;
                if (serie.nombre.Equals(nombre))
                {
                    serie_ok = serie;
                }
                else
                {
                    i++;
                }
            }
        }
        public ResultadoAlquiler verPelicula(string dni, string nombre)
        {
            ResultadoAlquiler result = ResultadoAlquiler.ALQUILER_OK;
            Cliente cliente = buscarCliente(dni);
            Pelicula pelicula = buscarPelicula(nombre);

            if (cliente == null)
            {
                result = ResultadoAlquiler.CLIENTE_INEXISTENTE;
            }
            else if (pelicula == null)
            {
                result = ResultadoAlquiler.CONTENIDO_INEXISTENTE;
            }
            else if (cliente.ObtenerSaldo() < 0)
            {
                result = ResultadoAlquiler.CLIENTE_DEUDOR;
            }
            else if (cliente.abono != TipoAbono.PREMIUM && pelicula.abono == TipoAbono.PREMIUM)
            {
                result = ResultadoAlquiler.CONTENIDO_NO_DISPONIBLE;
            }
            else
            {
                cliente.AgregarPelicula(pelicula);
            }
            return result;
        }


        private ResultadoAlquiler verSerie(Cliente cliente, CapituloSerie serie)
        {
            ResultadoAlquiler result = ResultadoAlquiler.ALQUILER_OK;


            if (cliente == null)
            {
                result = ResultadoAlquiler.CLIENTE_INEXISTENTE;
            }
            else if (serie == null)
            {
                result = ResultadoAlquiler.CONTENIDO_INEXISTENTE;
            }
            else if (cliente.ObtenerSaldo() < 0)
            {
                result = ResultadoAlquiler.CLIENTE_DEUDOR;
            }
            else if (cliente.abono != TipoAbono.PREMIUM && serie.abono == TipoAbono.PREMIUM)
            {
                result = ResultadoAlquiler.CONTENIDO_NO_DISPONIBLE;
            }
            else
            {
                cliente.AgregarSerie(serie);
            }
            return result;





        }
        private Pelicula buscarPelicula(string nombre)
        {
            Pelicula peli = null;
            foreach (var item in peliculas)
            {
                if (item.nombre.Equals(nombre)){
                    peli = item;
                }

            }
            return peli;
        }

        private Cliente buscarCliente(string dni)
        {
            Cliente cliente_ok = null, cliente;
            int i = 0;

            while (i < clientes.Count()&& cliente_ok == null)
            {
                cliente = clientes.GetRange(i);

            }
            {

            }
        }

        public void mostrarListas()
        {
            InOut.mostrar("Empresa: " + this.nombre);

            InOut.mostrar("Cliente: ");
            for (Cliente item : clientes)
            {
                InOut.mostrar(item.toString());
            }
            InOut.mostrar("Peliculas: ");
            for (Pelicula item : peliculas)
            {
                InOut.mostrar(item.toString());
            }

            InOut.mostrar("      Series:");

            for (CapituloSerie item : series)
            {
                InOut.mostrar(item.toString());
            }
        }


        @Override
    public String toString()
        {
            mostrarListas();
            return "";
        }

    }
}
}
