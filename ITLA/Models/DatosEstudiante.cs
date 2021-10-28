using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITLA.Models
{
    public class DatosEstudiante
    {
        //Atributos....
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public string Carrera { get; set; }
        public string GPS { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

    }
}