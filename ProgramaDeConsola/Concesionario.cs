using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeConsola
{
    class Concesionario
    {
        public string nombreConcesionario;
        public string direccionConcesionario;
        public int idConcesionario;

        public Concesionario(string nombreConcesionario, string direccionConcesionario, int idConcesionario)
        {
            this.nombreConcesionario = nombreConcesionario;
            this.direccionConcesionario = direccionConcesionario;
            this.idConcesionario = idConcesionario;
        }
    }
}
