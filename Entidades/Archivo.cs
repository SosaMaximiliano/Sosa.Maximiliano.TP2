using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Archivo
    {

        static string ruta;

        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Ganadores";
        }


        public static bool Escribir(string mensaje, string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"/{nombreArchivo}" + ".txt";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta,true))//Segundo parametro true: concatena
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}\n{ex.Message}");
            }

            //return false;
        }


        public static string Leer(string archivo)
        {

            string? rutaCompleta;
            string datos = string.Empty;

            if (Directory.Exists(ruta))
            {
                rutaCompleta = BuscarArchivo(ruta, archivo);
                if (rutaCompleta != null)
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        string line = sr.ReadToEnd();
                        datos += line;
                    }

                }
            }
            else
            {
                throw new Exception("No se encontró el archivo solicitado");
            }

            return datos;
        }


        private static string? BuscarArchivo(string ruta, string nombreArchivo)
        {
            string[] archivos = Directory.GetFiles(ruta);

            foreach (string item in archivos)
            {
                if (item.Contains(nombreArchivo))
                {
                    return item;
                }
            }

            return null;
        }


    }
}
