using System.Collections.Generic;
using Metodo_CRUD.Models;

class Program
{
    static void Main(string[] args)
    {
        //agregarCliente();
        //consultarClientes();
        //consultarCliente();
        //modificarCliente();
        //eliminarCliente();
        consultarClienteFunciones();
    }

    //Agregar cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ModeloDatosContext context = new ModeloDatosContext();
        Cliente std = new Cliente();
        std.Nombre = "Carlos";
        std.Apellido = "Hidalgo";
        std.Direccion = "Guayaquil";
        std.Telefono = "0960970974";
        std.FechaNacimiento = Convert.ToDateTime("1996-10-13");
        std.Estado = "Activo";
        context.Clientes.Add(std);
        context.SaveChanges();

        Console.WriteLine("Codigo: "+ std.Id+ " Nombre: " + std.Nombre);
    }

    //Consulta general
    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar cliente");
        ModeloDatosContext context = new ModeloDatosContext();
        List<Cliente> listEstudiantes = context.Clientes.ToList();

        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre);
        }
    }

    //Consulta por ID
    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        ModeloDatosContext context = new ModeloDatosContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(3);

        Console.WriteLine("Codigo: " + std.Id + " - Nombre: " + std.Nombre + " - Direccion: " +std.Direccion+ " - Telefono: " + std.FechaNacimiento + " - Estado: " +std.Estado);
    }

    //Modificar cliente por ID
    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente: ");
        ModeloDatosContext context = new ModeloDatosContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(3);

        std.Nombre = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);
    }

    //Eliminar cliente por ID
    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar cliente");
        ModeloDatosContext context = new ModeloDatosContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(4);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);
    }

    //Consultar funciones
    public static void consultarClienteFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        ModeloDatosContext context = new ModeloDatosContext();
        List<Cliente> listEstudiantes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente std = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla:" + std.Id + "-" + std.Nombre);

        listEstudiantes = context.Clientes.Where(s => s.Nombre.StartsWith("A")).ToList();



        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre);
        }
    }
}