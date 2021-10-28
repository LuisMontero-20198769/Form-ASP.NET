using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using SpreadsheetLight;

namespace ITLA.Models
{
    class EstudianteEXCEL : IEstrategy
    {
        public void Generar_Archivo(string id, string nombre, string apellido, string fechaNac, string carrera,
            string direccion, string telefono, string correo)
        {
            if (File.Exists("Estudiante.xlsx"))
            {
                SLDocument iLDocument = new SLDocument();
                SLWorksheetStatistics propiedades = iLDocument.GetWorksheetStatistics();
                int ultimafila = propiedades.EndRowIndex;

                for (int x = 2; x <= ultimafila; x++)
                {
                    string m = iLDocument.GetCellValueAsString("A" + x);
                    string n = iLDocument.GetCellValueAsString("B" + x);
                    string a = iLDocument.GetCellValueAsString("C" + x);
                    string c = iLDocument.GetCellValueAsString("D" + x);
                    string d = iLDocument.GetCellValueAsString("E" + x);
                    string t = iLDocument.GetCellValueAsString("F" + x);
                    string e = iLDocument.GetCellValueAsString("H" + x);
                    string v = iLDocument.GetCellValueAsString("I" + x);
                   


                    iLDocument.SetCellValue("A" + x, m);
                    iLDocument.SetCellValue("B" + x, n);
                    iLDocument.SetCellValue("C" + x, a);
                    iLDocument.SetCellValue("D" + x, c);
                    iLDocument.SetCellValue("E" + x, d);
                    iLDocument.SetCellValue("F" + x, t);
                    iLDocument.SetCellValue("H" + x, e);
                    iLDocument.SetCellValue("I" + x, v);
                    

                }
                iLDocument.SetCellValue("A" + ultimafila, id);
                iLDocument.SetCellValue("B" + ultimafila, nombre);
                iLDocument.SetCellValue("C" + ultimafila, apellido);
                iLDocument.SetCellValue("D" + ultimafila, fechaNac);
                iLDocument.SetCellValue("E" + ultimafila, carrera);
                iLDocument.SetCellValue("F" + ultimafila, direccion);
                iLDocument.SetCellValue("H" + ultimafila, telefono);
                iLDocument.SetCellValue("I" + ultimafila, correo);
              


                iLDocument.SaveAs("Estudiante.xlsx");
                Console.WriteLine("\nXLSX con exito!!!\n");
            }
            else
            {
                SLDocument eLDocument = new SLDocument();
                System.Data.DataTable dt = new System.Data.DataTable();

                dt.Columns.Add("Matricula", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido", typeof(string));
                dt.Columns.Add("Fecha de Nacimiento", typeof(string));
                dt.Columns.Add("Carrera", typeof(string));
                dt.Columns.Add("Direccion", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Correo", typeof(string));


                dt.Rows.Add(id, nombre, apellido, fechaNac, carrera, direccion, telefono, correo);

                eLDocument.ImportDataTable(1, 1, dt, true);

                eLDocument.SaveAs("Estudiante.xlsx");
                Console.WriteLine("\nXLSX con exito!!!\n");
            }
        }
    }
}
