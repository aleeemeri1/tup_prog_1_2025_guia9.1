namespace Guia9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaracion del vector
            int[] numeros;
            int contador;
            #endregion

            #region definicion de valor
            numeros = new int[100];
            #endregion

            #region inicializacion
            Console.WriteLine("Ingrese el valor:");
            int valor = Convert.ToInt32(Console.ReadLine());
            contador = 0;
            while (valor != -1) ;
            {
                numeros[contador] = valor;
                contador++;

                Console.WriteLine("Ingrese el valor:");
                valor = Convert.ToInt32(Console.ReadLine());
                numeros[contador] = valor;
            }
            #endregion

            for (int n = 0; n < contador; n++)
            {
                Console.Write($"{numeros[n],3}");
                Console.ReadKey();
            }
        }
    }
}
