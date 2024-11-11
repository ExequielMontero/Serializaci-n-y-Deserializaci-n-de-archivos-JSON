using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_archivos_Json.Models
{
    internal class Address
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public City City { get; set; }
    }
}
