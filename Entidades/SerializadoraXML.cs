using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraXML<T> : ISerializadora<T> where T : class
    {
        public string ruta;
        
        public SerializadoraXML()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Sosa.Maximiliano.TP2-Serializacion";
        }

        public void Escribir(T objeto, string nombreArchivo)
        {
            string rutaCompleta = ruta + @"\" + nombreArchivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }


                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(sw, objeto);
                }



            }
            catch (Exception)
            {

                throw new Exception($"Error en ruta {rutaCompleta}");
            }


        }

        public T Leer(string archivo)
        {
            string rutaCompleta = ruta + @"\" + archivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    throw new Exception("La ruta no existe");

                }

                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    if (serializer.Deserialize(sr) is T objeto)
                    {
                        return objeto;
                    }

                    throw new Exception("Error al deserealizar.");

                }


            }
            catch (Exception)
            {

                throw;
            }



        }


    }
}
