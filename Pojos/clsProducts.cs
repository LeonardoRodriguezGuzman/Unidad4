using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4.Pojos
{
    internal class clsProducts
    {
        private int productID;
        private string productName;
        private double unitPrice;

        public clsProducts(int productID, string productName, double unitPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
        }

        public string toString()
        {
            return "Id = " + productID + ".\nNombre = " + productName + ".\nPrecio por Unidad = " + unitPrice+".";
        }
    }
}
