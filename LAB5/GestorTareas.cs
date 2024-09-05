using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class GestorTareas
    {
        List<Tarea> listaTareas = new List<Tarea>();
        Mensajes mensaje = new Mensajes();
        public void AgregarTarea()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n ╔═════════════════════════════════════════════╗"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ║            N U E V A   T A R E A            ║"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
            Console.Write(" Ingrese el nombre: ");
            string nombreTarea = Console.ReadLine();
            Console.Write(" Ingresa una breve descripción: ");
            string descripcion = Console.ReadLine();
            Tarea nuevaTarea = new Tarea(nombreTarea, descripcion, false);
            listaTareas.Add(nuevaTarea);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Espera");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000); //para esperar un segundo 
                Console.Write(".");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n ¡Tarea agregada exitosamente!");
            mensaje.Continuar();
        }

        public void VerTareas()
        {
            if(listaTareas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" Aun no hay tareas...");
                Console.ReadKey(); Console.Clear();
                return;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n ╔═════════════════════════════════════════════╗"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ║              V E R   T A R E A S            ║"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
            foreach(Tarea tarea in listaTareas)
            {
                tarea.MostrarTareas(); Console.WriteLine();
            }
            mensaje.Continuar();
        }
        public void Salir()
        {
            Console.Clear(); Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("        █████  ██████  ██  ██████  ███████ \r\n       ██   ██ ██   ██ ██ ██    ██ ██      \r\n       ███████ ██   ██ ██ ██    ██ ███████ \r\n       ██   ██ ██   ██ ██ ██    ██      ██ \r\n       ██   ██ ██████  ██  ██████  ███████ \r\n                                    \r");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ╔═════════════════════════════════════════════╗");
            Console.WriteLine(" ║              Ten un buen día :)             ║");
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
        }
    }
}
