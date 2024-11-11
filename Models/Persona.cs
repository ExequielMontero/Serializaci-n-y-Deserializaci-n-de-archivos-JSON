using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_archivos_Json.Models
{
    internal class Persona
    {
       

        public string Name{ get; set; }
        public Address Address { get; set; }

        public List<Phone> Phones { get; set; }
        public DateTime DateOfBirth { get; set; }





    }
}
