namespace OrtFlix
{
    public class CapituloSerie
    {

        public string  nombre { get; set; }
        public int temporada { get; set; }
        public int capitulo { get; set; }
        public TipoAbono abono { get; set; }



        public CapituloSerie (string nombre, TipoAbono abono, int temporada, int capitulo)
        {
            this.nombre = nombre;
            this.abono = abono;
            this.temporada = temporada;
            this.capitulo = capitulo;

        }
    }
}