using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Venta
    {
        //Codigo Articulo
        //Cantidad
        //Codigo Cliente (1 a 100)

        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }

        private int codCliente;
        public int CodigoCliente
        {
            get { return codCliente; }
            set
            {
                if (value > 0 && value < 101)
                    codCliente = value;
                else
                    codCliente = -1;
            }
        }
    }
}
