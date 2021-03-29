using System;
using System.Globalization;

namespace A133590.Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 26");
            Console.WriteLine("Programa que imprime información sobre una fecha válida.");

            Console.Write("Por favor, ingrese una fecha: ");
            DateTime fecha;
            if (!DateTime.TryParse(Console.ReadLine(), out fecha))
            {
                Console.WriteLine("La fecha ingresada no es válida.");
                return;
            }

            Console.WriteLine($"Día: {fecha.Day}");
            Console.WriteLine($"Año: {fecha.Year}");
            Console.WriteLine($"Mes: {fecha.Month} - {CultureInfo.CreateSpecificCulture("es").DateTimeFormat.GetMonthName(fecha.Month)}");
            Console.WriteLine($"Dia de la semana: {(int)fecha.DayOfWeek}");
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
