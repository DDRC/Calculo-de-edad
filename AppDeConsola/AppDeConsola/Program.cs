using System;
using System.Threading.Tasks.Dataflow;

namespace AppDeConsolaEdad
{
    class Edadpersona
    {
        static void Main(string[] Datos)
        {
            if (Datos.Length > 0 && Datos.Length==2)
            {
                int añoActual = 2020;
                Console.WriteLine("Hola " + Datos[0]+" "+Datos[1]);
                Console.Write("Por favor ingresa tu año de nacimiento:");
                String fecNac = Console.ReadLine();
                int añoNacimiento = int.Parse(fecNac);
                int edad = añoActual - añoNacimiento;
                Console.Write("Vaya al parecer tu edad es " + edad);
                Console.WriteLine(" Años !!");
                Console.WriteLine("Presione Enter para salir");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Debe ingresar su nombre y apellido, para continuar con el proceso");
                Console.WriteLine("Presione Enter para salir");
                Console.ReadKey();
            }
            
        }
    }
}
