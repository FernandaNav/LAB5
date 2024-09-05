using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Mensajes
    {
        public void Continuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" Presiona ENTER para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }
        public void ErrorDeFormato()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Error de formato.");
            Console.ResetColor();
        }
        public void ErrorDeEntero()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" El número es demasiado largo.");
            Console.ResetColor();
        }
        public void Default()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Esta opción no existe"); Console.ResetColor();
            Continuar();
        }
        public void Iniciar()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n ╔═════════════════════════════════════════════╗");
            Console.WriteLine(" ║             G E S T O R    D E              ║");
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("████████  █████  ██████  ███████  █████  ███████ \r\n   ██    ██   ██ ██   ██ ██      ██   ██ ██      \r\n   ██    ███████ ██████  █████   ███████ ███████ \r\n   ██    ██   ██ ██   ██ ██      ██   ██      ██ \r\n   ██    ██   ██ ██   ██ ███████ ██   ██ ███████ \r\n                                                 \r\n                                                 ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < 25; i++)
            {
                Console.Write(" █");
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\n        Presiona ENTER para iniciar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }

        public void Espera()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Espera");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
        }
    }
}
