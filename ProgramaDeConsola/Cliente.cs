using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeConsola
{
    class Cliente
    {
        public string clienteNombre;
        public string direccion;
        public int CI;
        public int telefono;

        public Cliente(string clienteNombre, string direccion, int CI, int telefono)
        {
            this.clienteNombre = clienteNombre;
            this.direccion = direccion;
            this.CI = CI;
            this.telefono = telefono;
               
        }
    }
}
