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
            mensaje.Espera();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n ¡Tarea agregada exitosamente!");
            mensaje.Continuar();
        }

        public void VerTareas()
        {
            if (listaTareas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" Aun no hay tareas...");
                mensaje.Continuar();
                return;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n ╔═════════════════════════════════════════════╗"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ║             V E R   T A R E A S             ║"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
            foreach (Tarea tarea in listaTareas)
            {
                tarea.MostrarTareas(); Console.WriteLine();
            }
            mensaje.Continuar();
        }

        public void MarcarCompletada()
        {
            if (listaTareas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" Aun no hay tareas...");
                mensaje.Continuar();
                return;
            }
            bool tareaEncontrada = false, validarNumero = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n ╔═════════════════════════════════════════════╗"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ║        MARCAR TAREA COMO COMPLETADA         ║"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" ╚═════════════════════════════════════════════╝"); Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("         (Presiona ENTER para cancelar)"); Console.ResetColor();
                Console.Write("\n Ingresa el número de tarea: ");
                try
                {
                    int numeroDeTarea = Convert.ToInt32(Console.ReadLine());
                    foreach (var tarea in listaTareas)
                    {
                        if (numeroDeTarea == tarea.NumeroTarea && tarea.Estado == false)
                        {
                            tareaEncontrada = true;
                            mensaje.Espera();
                            tarea.Estado = true;
                            Console.ForegroundColor = ConsoleColor.Magenta; 
                            Console.WriteLine("\n\n ¡Tarea Completada!");
                            validarNumero = true;
                            mensaje.Continuar();
                        }
                        else if (numeroDeTarea == tarea.NumeroTarea && tarea.Estado == true)
                        {
                            tareaEncontrada = true;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(" Esta tarea ya está completada, presiona ENTER para continuar...");
                            Console.ReadKey();
                            validarNumero = true;
                            Console.ResetColor(); Console.Clear();
                        }
                    }
                    if (!tareaEncontrada)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(" Numero de tarea no encontrado.");
                        mensaje.Continuar();
                    }
                }
                catch (FormatException)
                {
                    validarNumero = true;
                    mensaje.ErrorDeFormato(); mensaje.Continuar();
                }
                catch (OverflowException)
                {
                    validarNumero = true;
                    mensaje.ErrorDeEntero(); mensaje.Continuar();
                }
            } while (!validarNumero);
        }
        public void Salir()
        {
            Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n Saliendo...\n\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" █");
                Thread.Sleep(50);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n        █████  ██████  ██  ██████  ███████ \r\n       ██   ██ ██   ██ ██ ██    ██ ██      \r\n       ███████ ██   ██ ██ ██    ██ ███████ \r\n       ██   ██ ██   ██ ██ ██    ██      ██ \r\n       ██   ██ ██████  ██  ██████  ███████ \r\n                                    \r");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ╔═════════════════════════════════════════════╗");
            Console.WriteLine(" ║              Ten un buen día :)             ║");
            Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
        }
    }
}
