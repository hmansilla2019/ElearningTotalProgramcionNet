using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoristaEstrellaEntities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreApellido { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Nacionalidad { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
