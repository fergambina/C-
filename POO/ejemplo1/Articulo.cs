using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Articulo
    {
        private int codigo;
        private float precio;

        public void setCodigo(int c)
        {
            codigo = c;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public float getPrecio()
        {
            return precio;
        }

        public void setPrecio(float p)
        {
            precio = p;
        }

    }
}
