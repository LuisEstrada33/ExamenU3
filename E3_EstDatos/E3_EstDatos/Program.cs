using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion op = new Operacion();
            Console.Write("El valor que devuelve es: ");
            op.Ejercicio1();
            op.Ejercicio2();
            op.Ejercicio3();
            op.Ejercicio4();
            Console.ReadKey();
        }
    }
}
