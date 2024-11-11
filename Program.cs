using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serializar_y_Deserializar_archivos_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serializacion de un Objeto a Json
            
            /*Persona actual = new Persona("Exequiel", "Montero", "exequielalejandromontero@gmail.com", 21);
            string MiJson = JsonSerializer.Serialize(actual);
            File.WriteAllText("objeto.txt",MiJson);*/


            
            //Deserializacion de un Json a objeto
            string MiJsonDes = File.ReadAllText("objeto.txt");
            Persona persona = JsonSerializer.Deserialize<Persona>(MiJsonDes);
            Console.WriteLine(persona.ToString());
        }
    }
}
