using System;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel WCG!");

            Console.WriteLine("Cantidad Huespedes");
            int huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Dias de estadia");
            int cant_dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de Habitacion");
            string nom_hab = Console.ReadLine();

            //Instancia

            var hotelUno = new GestionHotel()
            {
                habitacion = nom_hab,
                huesped = huespedes,
                dias = cant_dias
            };

            hotelUno.cuentaCobro();
        }
    }
}