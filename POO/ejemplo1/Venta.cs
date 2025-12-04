using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Venta
    {
        private int codigoArticulo;
        private int cantidad;
        private int codigoCliente;

        public int getCodigoArticulo()
        {
            return codigoArticulo; 
        }
        public void setCodigoArticulo(int c) 
        {
            codigoArticulo = c;
        }

        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int c)
        {
            cantidad = c;
        }

        public int getCodigoCliente()
        {
            return codigoCliente;
        }
        public void setCodigoCliente(int c)
        {
            codigoCliente = c;
        }

    }
}
