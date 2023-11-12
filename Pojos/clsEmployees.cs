using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4.Pojos
{
    internal class clsEmployees
    {
        int id;
        string Nombre;
        public clsEmployees(int id, string Nombre)
        {
            this.id = id;
            this.Nombre = Nombre;
        }

        public int getId() { return id; }
        public string getNombre() { return Nombre; }
        public string empleado
        {
            get { return $"{getId()}. {getNombre()}"; }
        }
    }
}
