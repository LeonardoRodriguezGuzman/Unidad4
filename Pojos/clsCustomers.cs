using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4.Pojos
{
    internal class clsCustomers
    {
        string id;
        string Nombre;
        public clsCustomers(string id, string Nombre)
        {
            this.id = id;
            this.Nombre = Nombre;
        }

        public string getId() { return id; }
        public string getNombre() { return Nombre; }
        public string customers
        {
            get { return $"{getId()}. {getNombre()}"; }
        }
    }
}
