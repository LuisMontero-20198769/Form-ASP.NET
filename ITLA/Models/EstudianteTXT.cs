using ITLA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ITLA.Models
{
    class EstudianteTXT : IEstrategy
    {
        public void Generar_Archivo(string id, string nombre, string apellido, string fechaNac, string carrera,
            string direccion, string telefono, string correo)
        {
            StreamWriter TXT = new StreamWriter("empleado.txt");
            TXT.WriteLine(
             $"*****    DATOS DEL ESTUDIANTE    ******\n"+
             $"Matricula: {id}"+
             $"Nombre: {nombre}\n" +
             $"Apellido: {apellido}\n" +
             $"Fecha de nacimiento: {fechaNac} \n" +
             $"Carrera:  {carrera} \n" +
             $"Direccion: {direccion} \n"+
             $"Telefono: {telefono}\n"+
             $"Correo: {correo}"
             );
            TXT.Close();
        }
    }
}
