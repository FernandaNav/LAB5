
using LAB5;

int opcion = 0;
Mensajes mensajes = new Mensajes();
do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("**********************************"); Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("           BIENVENIDO"); Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("**********************************\n"); Console.ResetColor();
    Console.WriteLine("    1. Añadir tarea.");
    Console.WriteLine("    2. Ver tareas.");
    Console.WriteLine("    3. Marcar tarea completada.");
    Console.WriteLine("    4. Salir.\n"); Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Ingrese la opción: "); 
    try
    {
        opcion = Convert.ToInt32(Console.ReadLine()); Console.ResetColor();
        switch (opcion)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                mensajes.Default();
                break;
        }
    }
    catch(FormatException)
    {
        mensajes.ErrorDeFormato();
    }
    catch (OverflowException)
    {
        mensajes.ErrorDeFormato();
    }
} while (opcion != 4);

