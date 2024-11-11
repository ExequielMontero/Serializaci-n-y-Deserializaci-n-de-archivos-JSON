using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_archivos_Json
{
    internal class Persona
    {
        public Persona(string nombre, string apellido, string email, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Edad = edad;
        }

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public string Email { get; private set; }
        public int Edad { get; private set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Edad: {Edad}";
        }

    }
}
