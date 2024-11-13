using System.Collections.Generic;
using System;


[Serializable]
public class Aerolinea
{
    public List<Vuelo> Vuelos { get; set; } = new List<Vuelo>();

    public void AgregarVuelo()
    {
        Vuelo vuelo = new Vuelo();

        Console.Write("Código de vuelo: ");
        vuelo.Codigo = Console.ReadLine();
        vuelo.Salida = LeerFecha("Fecha y hora de salida (dd/MM/yyyy HH:mm): ");
        vuelo.Llegada = LeerFecha("Fecha y hora de llegada (dd/MM/yyyy HH:mm): ");

        while (vuelo.Llegada <= vuelo.Salida)
        {
            Console.WriteLine("La fecha de llegada debe ser posterior a la de salida. Intente nuevamente.");
            vuelo.Llegada = LeerFecha("Fecha y hora de llegada (dd/MM/yyyy HH:mm): ");
        }

        Console.Write("Nombre del piloto: ");
        vuelo.Piloto = Console.ReadLine();
        Console.Write("Nombre del copiloto: ");
        vuelo.Copiloto = Console.ReadLine();
        vuelo.CapacidadMaxima = LeerEntero("Capacidad máxima: ");

        Vuelos.Add(vuelo);
        Console.WriteLine("Vuelo agregado.");
        Console.ReadKey();
    }

    public void RegistrarPasajeros()
    {
        Console.Write("Código de vuelo: ");
        string codigo = Console.ReadLine();
        int cantidad = LeerEntero("Cantidad de pasajeros: ");
        Vuelo vuelo = BuscarVuelo(codigo);
        if (vuelo != null)
        {
            vuelo.RegistrarPasajeros(cantidad);
            Console.WriteLine("Pasajeros registrados.");
        }
        else
        {
            Console.WriteLine("Vuelo no encontrado.");
        }
        Console.ReadKey();
    }

    public double OcupacionMedia()
    {
        if (Vuelos.Count == 0) return 0;
        double total = 0;
        foreach (Vuelo vuelo in Vuelos)
        {
            total += vuelo.Ocupacion;
        }
        return total / Vuelos.Count;
    }

    public void MostrarVueloMayorOcupacion()
    {
        Vuelo maxVuelo = null;
        double maxOcupacion = -1;

        foreach (Vuelo vuelo in Vuelos)
        {
            if (vuelo.Ocupacion > maxOcupacion)
            {
                maxOcupacion = vuelo.Ocupacion;
                maxVuelo = vuelo;
            }
        }

        if (maxVuelo != null)
        {
            Console.WriteLine("Vuelo mayor ocupación: " + maxVuelo.Codigo + " - " + maxVuelo.Ocupacion + "%");
        }
        else
        {
            Console.WriteLine("No hay vuelos registrados.");
        }
        Console.ReadKey();
    }

    public Vuelo BuscarVuelo(string codigo)
    {
        foreach (Vuelo vuelo in Vuelos)
        {
            if (vuelo.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
            {
                return vuelo;
            }
        }
        return null;
    }

    public void ListarVuelos()
    {
        if (Vuelos.Count == 0)
        {
            Console.WriteLine("No hay vuelos registrados.");
        }
        else
        {
            foreach (Vuelo vuelo in Vuelos)
            {
                Console.WriteLine("Código: " + vuelo.Codigo + ", Ocupación: " + vuelo.Ocupacion + "%");
            }
        }
        Console.ReadKey();
    }

    public void CargarDatos(string archivo)
    {
   
    }

    public void GuardarDatos(string archivo)
    { 
    }

    private DateTime LeerFecha(string mensaje)
    {
        DateTime fecha;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (DateTime.TryParse(entrada, out fecha))
            {
                return fecha;
            }
            Console.WriteLine("Fecha no válida. Intente nuevamente.");
        }
    }

    private int LeerEntero(string mensaje)
    {
        int num;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out num) && num > 0)
            {
                return num;
            }
            Console.WriteLine("Número no válido. Intente nuevamente.");
        }
    }
}
