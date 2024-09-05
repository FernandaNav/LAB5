
using LAB5;

int opcion = 0;
Mensajes mensajes = new Mensajes();
GestorTareas tarea = new GestorTareas();
mensajes.Iniciar();
do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\n ╔═════════════════════════════════════════════╗"); Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(" ║             B I E N V E N I D O             ║"); Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" ╚═════════════════════════════════════════════╝\n"); Console.ResetColor();
    Console.WriteLine("     1. Añadir tarea.");
    Console.WriteLine("     2. Ver tareas.");
    Console.WriteLine("     3. Marcar tarea completada.");
    Console.WriteLine("     4. Salir.\n"); Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(" Ingrese la opción: "); 
    try
    {
        opcion = Convert.ToInt32(Console.ReadLine()); Console.ResetColor();
        switch (opcion)
        {
            case 1:
                tarea.AgregarTarea();
                break;
            case 2:
                tarea.VerTareas();
                break;
            case 3:
                break;
            case 4:
                tarea.Salir();
                break;
            default:
                mensajes.Default();
                break;
        }
    }
    catch(FormatException)
    {
        mensajes.ErrorDeFormato();
        mensajes.Continuar();
    }
    catch (OverflowException)
    {
        mensajes.ErrorDeFormato();
        mensajes.Continuar();
    }
} while (opcion != 4);

