using System;
using System.IO;


namespace AplicaciónDeEjemplo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Pedimos nombre del Archivo
            Console.WriteLine("Ingrese Nombre del Archivo");
            String Arc = Console.ReadLine();

            //Abrimos o Creamos un Archivo si no existe.
            Stream Archivo = new FileStream("./" + Arc + ".txt", FileMode.OpenOrCreate);

            //Esbribimos en nuestro Archivo mediante StramWrite
            StreamWriter Escribir = new StreamWriter(Archivo);

            Console.WriteLine("Ingres texto para escribir en: " + Arc + ".txt");
            String Texto = Console.ReadLine();

            Escribir.WriteLine(Texto);

            //Cerramos
            Escribir.Close();
            Archivo.Close();

            //Abrimos o Creamos un Archivo si no existe.
            Stream Archivo2 = new FileStream("./" + Arc + ".txt", FileMode.OpenOrCreate);
            Console.WriteLine("\nLectura:\n");

            //Leemos nuestro archivo mediante StreamReader
            StreamReader Leer = new StreamReader(Archivo2);
            Console.WriteLine(Leer.ReadToEnd());

            //Cerramos
            Leer.Close();
            Archivo2.Close();

        }
    }
}