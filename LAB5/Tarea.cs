using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public class Tarea
    {
        static int contador = 0;
        private int NumeroTarea {  get; set; }
        protected string NombreTarea { get; set; }
        protected string Descripcion {  get; set; }
        protected bool Estado {  get; set; }

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
            Console.WriteLine($"--Tarea #{NumeroTarea}");
            Console.ResetColor();
            Console.WriteLine($"Nombre: {NombreTarea}");
            Console.WriteLine($"Descripción: {Descripcion}");
            if(Estado == true)
            {
                Console.WriteLine("Estado: Tarea Completada");
            }
            else
            {
                Console.WriteLine("Estado: Tarea Pendiente");
            }
        }
    }
}
