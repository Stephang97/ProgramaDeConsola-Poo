using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeConsola
{
    class Vehiculo
    {
        //propiedades
        public string marca ;
        public string placa;
        public int modelo;
        public string matricula;

        //metodos

        public Vehiculo(string marca, string placa, int modelo, string matricula)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.matricula = matricula;

        }
    }
}
