using System;
using Newtonsoft.Json;
using System.IO;
using ITLA.Models;

namespace ITLA.Models
{
    class EstudianteJSON : IEstrategy
    {
        public void Generar_Archivo(string id, string nombre, string apellido, string fechaNac, string carrera,
            string direccion, string telefono, string correo)
        {
            string almacena = $"*****  DATOS DEL ESTUDIANTE  ********" +
                $"\nMatricula: {id}\n"+
                $"Nombre: {nombre}\n" +
                $"Apellido: {apellido}\n" +
                $"Fecha de nacimiento: {fechaNac}\n" +
                $"Carrera: {carrera}\n" +
                $"Direccion: {direccion}\n" +
                $"Telefono: {telefono}\n" +
                $"E-mail: {correo}";
            string pathFile = "empleados.json";
            string vJson = JsonConvert.SerializeObject(almacena, (Newtonsoft.Json.Formatting)System.Xml.Formatting.None);
            File.AppendAllText(pathFile, vJson);
            Console.WriteLine("\nArchivo JSON guardado!!\n");
        }
    }
}
