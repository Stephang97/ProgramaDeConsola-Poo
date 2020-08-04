using System;

namespace ProgramaDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo automovil = new Vehiculo("Mazda", "PBE208", 2014, "PDO-01234");
            Vendedor señorVendedor = new Vendedor("Juan", "Perez", 21, 18);
            Cliente nuevoCliente = new Cliente("Pablo Martinez", "Av. Patria", 1723456098, 3037123);
            Concesionario lugarConcesionario = new Concesionario("Casamotors", "Av. 6 de Diciembre", 07);
            
            Console.WriteLine("La primera venta de la semana fue hecha por " + señorVendedor.nombreVendedor + " " + señorVendedor.apellido + " al señor " + nuevoCliente.clienteNombre + " en la agencia " + lugarConcesionario.nombreConcesionario);
            Console.WriteLine("El señor " + nuevoCliente.clienteNombre + " fue atendido en la oficina " + señorVendedor.oficina);
            Console.WriteLine("El vendedor " + señorVendedor.nombreVendedor + " " + señorVendedor.apellido + " reportó la venta con el id " + señorVendedor.id);


        }
    }
}
