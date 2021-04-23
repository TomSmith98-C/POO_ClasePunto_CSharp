using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Realizar_Tarea();
        }
        static void Realizar_Tarea() {

            Punto origen = new Punto();
            Console.WriteLine("El origen es de:" + origen.Mostrar());
            origen.setX(2);
            origen.setY(6);
            Console.WriteLine("El nuevo punto es de:" + origen.Mostrar());

            Punto PHasta = new Punto(4,5);
            Console.WriteLine("El destino es de:" + PHasta.Mostrar());
            Console.WriteLine("La distancia entre los puntos es de:"+ origen.DistanciaHasta(PHasta));



        }
    }
}
