using System;
using System.Collections.Generic;
using System.Text;

namespace ITLA.Models
{
    class LogicaArchivo
    {
        public void RegistrarArchivo(string id, string nombre, string apellido, string fechaNac, string carrera,
            string direccion, string telefono, string correo)
        {
            CONTEXTO contexto = null;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n*****          SELCCIONE COMO GUARDAR EL ARCHIVO          *****");
            Console.WriteLine("[1] Archivo TXT         [2] Archivo EXCEL         [3] Archivo JSON");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo TXT!!\n");
                EstudianteTXT txt = new EstudianteTXT();
                contexto = new CONTEXTO(txt);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo EXCEL!!\n");
                EstudianteEXCEL excel = new EstudianteEXCEL();
                contexto = new CONTEXTO(excel);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("\nHaz seleccionado archivo tipo JSON!!\n");
                EstudianteJSON json = new EstudianteJSON();
                contexto = new CONTEXTO(json);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nALERTA!!\n");
                
            }
            Console.ResetColor();
            contexto.CreadorArchivo(id, nombre, apellido, fechaNac, carrera, direccion, telefono, correo);
        }
    }
}
