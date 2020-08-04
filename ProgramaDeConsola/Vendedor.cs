using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeConsola
{
    class Vendedor
    {
        public string nombreVendedor;
        public string apellido;
        public int id;
        public int oficina;

        public Vendedor(string nombreVendedor, string apellido, int id, int oficina)
        {
            this.nombreVendedor = nombreVendedor;
            this.apellido = apellido;
            this.id = id;
            this.oficina = oficina;
        }
    }
}
