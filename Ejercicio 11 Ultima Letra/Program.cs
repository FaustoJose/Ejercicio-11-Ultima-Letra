using System;

namespace Ejercicio_11_Ultima_Letra
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("La ultima letra de esta palabra es :" + Cadena2("Hola"));
        }
        public static string Cadena2(string palabra)
        {
            string ultima = palabra.Substring(palabra.Length-1,1);
            return ultima;
        }
    }
}
