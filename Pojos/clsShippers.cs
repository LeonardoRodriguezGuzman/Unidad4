using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4.Pojos
{
    internal class clsShippers
    {
        int id;
        string Nombre;
        public clsShippers(int id, string Nombre)
        {
            this.id = id;
            this.Nombre = Nombre;
        }

        public int getId() { return id; }
        public string getNombre() { return Nombre; }
        public string shippers
        {
            get { return $"{getId()}. {getNombre()}"; }
        }
    }
}
