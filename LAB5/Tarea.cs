using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Tarea
    {
        static int contador = 1;
        public int NumeroTarea {  get; set; }
        private string NombreTarea { get; set; }
        private string Descripcion {  get; set; }
        public bool Estado {  get; set; }

        public Tarea(string nombreTarea, string descripcion, bool estado)
        {
            NumeroTarea = contador++;
            NombreTarea = nombreTarea;
            Descripcion = descripcion;
            Estado = estado;
        }

        public void MostrarTareas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" ═══════Tarea #{NumeroTarea}");
            Console.ResetColor();
            Console.WriteLine($" Nombre: {NombreTarea}");
            Console.WriteLine($" Descripción: {Descripcion}");
            if(Estado == true)
            {
                Console.WriteLine(" Estado: Completada");
            }
            else
            {
                Console.WriteLine(" Estado: Pendiente");
            }
        }
    }
}
