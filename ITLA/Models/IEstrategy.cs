using System;
using System.Collections.Generic;
using System.Text;

namespace ITLA.Models
{
    interface IEstrategy
    {
        void Generar_Archivo(string id, string nombre, string apellido, string fechaNac, string carrera,
            string direccion, string telefono, string correo);
    }
}
