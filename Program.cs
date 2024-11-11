using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serializar_y_Deserializar_archivos_Json.Models;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Serializar_y_Deserializar_archivos_Json
{
    class Program
    {
        static string Path = "objeto.txt";
        static void Main(string[] args)
        {
            //var personas = GetPersonas();
            //SerializeJsonFile(personas);

            var personas = GetPersonasJSonFromFile();
            var lista = DeserializeJSON(GetPersonasJSonFromFile());

        }

        #region Escribir JSON 
        public static void SerializeJsonFile(List<Persona> personas)
        {
            string JsonPersona = JsonConvert.SerializeObject(personas.ToArray(), Formatting.Indented);
            File.WriteAllText("Objeto.txt",JsonPersona);
        }
        public static List<Persona> GetPersonas()
        {
            List<Persona> Personas = new List<Persona>
            {
                new Persona
                {
                    Name = "Exequiel Montero",
                    DateOfBirth = new DateTime(2003,04, 23),
                    Address = new Address{
                            Street = "Irigoyen",
                            Number = 421,
                            City = new City{
                                Name = "Parana",
                                Country = new Country{Name = "Parana",Code = "3100" }
                            }

                    },
                    Phones = new List<Phone>
                    {
                        new Phone{Name = "Personal", Number = "03434154153"},
                        new Phone{Name = "Claro", Number = "0343534565"}
                    }

                }
            };
            return Personas;
        }
        #endregion Fin escribri JSON

        #region Deserializacion JSON
        public static string GetPersonasJSonFromFile()
        {
            string JsonFile;
            using (var reader = new StreamReader(Path))
            {
                JsonFile = reader.ReadToEnd();
            }
            return JsonFile;
        }

        public static List<Persona> DeserializeJSON(string JSON)
        {
            var personas = JsonConvert.DeserializeObject<List<Persona>>(JSON);
            return personas;
        }
        #endregion Fin Deserializacion JSON 
    }
}

