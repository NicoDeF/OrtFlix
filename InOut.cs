
namespace OrtFlix

{
    public class InOut
    {

		private static Scanner input = null;

		/**
		 * Este mï¿½todo se encarga de generar un Scanner, pero sï¿½lo cuando hace
		 * falta.
		 * 
		 * El programa lo va a pedir y utilizar cuando lo necesite, pero para
		 * nosotros, que la usamos desde afuera, es transparente.
		 * 
		 * @return
		 */
		private static Scanner getScanner()
		{
			if (input == null)
			{
				input = new Scanner(System.in);
			}
			return input;
		}

		/**
		 * Este metodo pide la carga por teclado de un numero double (real)
		 * validando que este dentro del rango indicado por minimo y maximo.
		 * 
		 * @param mensaje
		 *            El mensaje a mostrar por pantalla para cargarlo.
		 * @param minimo
		 *            El limite inferior del rango.
		 * @param maximo
		 *            el limite superior del rango.
		 * @return un numero valido
		 */
		public static double pedirDobleEnRango(String mensaje, double minimo, double maximo)
		{
			double nro;
			nro = pedirDouble(mensaje);
			while (nro < minimo || nro > maximo)
			{
				// mostrar el error
				mostrar("Ingreso erroneo, el valor debe estar entre " + minimo + " y " + maximo);
				// volver a pedir
				nro = pedirDouble(mensaje);
			}
			return nro;
		}

		/**
		 * Este metodo pide la carga por teclado de un numero double (real) sin
		 * validarlo.
		 * 
		 * @param mensaje
		 *            El mensaje a mostrar por pantalla para cargarlo.
		 * @return el numero cargado
		 */
		public static double pedirDouble(String mensaje)
		{
			double numero;
			mostrar(mensaje);
			numero = Double.parseDouble(getScanner().nextLine());
			return numero;
		}

		public static int pedirEnteroEnRango(String mensaje, int minimo, int maximo)
		{
			int nro;
			nro = pedirEntero(mensaje + " entre " + minimo + " y " + maximo);
			while (nro < minimo || nro > maximo)
			{
				// mostrar el error
				mostrar("Ingreso erroneo, el valor debe estar entre " + minimo + " y " + maximo);
				// volver a pedir
				nro = pedirEntero(mensaje);
			}
			return nro;
		}

		/**
		 * Pide un numero entero.
		 * 
		 * @param mensaje
		 *            El mensaje a mostrar en pantalla
		 * @return Un numero entero (int) sin validar
		 */
		public static int pedirEntero(String mensaje)
		{
			int numero;
			mostrar(mensaje);
			numero = Integer.parseInt(getScanner().nextLine());
			return numero;
		}

		public static void mostrar(String mensaje)
		{
			System.out.println(mensaje);
		}

		public static boolean preguntarSiNo(String mensaje)
		{
			String respuesta;
			boolean ok;
			do
			{
				respuesta = pedirTexto(mensaje + " (S/N)");
			} while (!(respuesta.equalsIgnoreCase("S") || respuesta.equalsIgnoreCase("N")));
			ok = respuesta.equalsIgnoreCase("S");
			return ok;
		}

		public static String pedirTexto(String mensaje)
		{
			String texto;
			mostrar(mensaje);
			texto = getScanner().nextLine();
			return texto;
		}

		public static String pedirTextoValidado(String mensaje, String valoresPosibles)
		{
			String valor = pedirTexto(mensaje);
			while (valoresPosibles.toUpperCase().indexOf(valor.toUpperCase()) == -1)
			{
				mostrar("El valor ingresado no estÃ¡ entre los esperados");
				valor = pedirTexto(mensaje);
			}
			return valor;
		}

		public static String pedirTextoValidado(String mensaje, String valoresPosibles, boolean aceptaEnter)
		{
			String valor = pedirTexto(mensaje);
			while ((aceptaEnter && valor.isEmpty()) || ((!valor.isEmpty()) && (valoresPosibles.toUpperCase().indexOf(valor.toUpperCase()) == -1)))
			{
				mostrar("El valor ingresado no estÃ¡ entre los esperados");
				valor = pedirTexto(mensaje);
			}
			return valor;
		}

		public static String pedirTextoNoVacio(String mensaje, String mensajeDeError)
		{
			String valor = InOut.pedirTexto(mensaje);
			while (valor.isEmpty())
			{
				InOut.mostrar(mensajeDeError);
				valor = InOut.pedirTexto(mensaje);
			}
			return valor;
		}

	}
}
}