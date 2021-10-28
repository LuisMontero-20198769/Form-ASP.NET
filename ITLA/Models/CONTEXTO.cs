using ITLA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITLA.Models
{
    class CONTEXTO 
    {
        IEstrategy estrategia;
        public CONTEXTO(IEstrategy objeto)
        {
            this.estrategia = objeto;
        }
        public void CreadorArchivo(string id, string nombre, string apellido, string fechaNac, 
            string carrera, string direccion, string telefono, string correo)
        {
            estrategia.Generar_Archivo(id, nombre, apellido, fechaNac, carrera, direccion, telefono, correo);
        }

    }
}
