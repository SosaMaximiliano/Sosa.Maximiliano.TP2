using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraJSON<T> : ISerializadora<T> where T : class
    {
        public static string ruta;
        
        public SerializadoraJSON()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Sosa.Maximiliano.TP2-Serializacion";
        }

        public void Escribir(T objeto, string nombreArchivo)
        {
            try
            {
                string rutaCompleta = ruta + @"/" + nombreArchivo + ".json";

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string objetoJson = JsonSerializer.Serialize(objeto);

                try
                {
                    File.WriteAllText(rutaCompleta, objetoJson);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al intentar leer o escribir el archivo. {ex.Message}");

                }

            }
            catch (PathTooLongException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T Leer(string archivo)
        {
            T datos = default;

            string rutaCompleta = ruta + @"/" + archivo + ".json";

            if (!Directory.Exists(ruta))
            {
                throw new Exception("La ruta no existe");

            }

            string archivoJson = File.ReadAllText(rutaCompleta);

            datos = JsonSerializer.Deserialize<T>(archivoJson);

            return datos;
        }


    }
}
