using System;

class Menu
{
    private readonly Aerolinea _aerolinea;
    private readonly string _archivo;

    public Menu(Aerolinea aerolinea, string archivo)
    {
        _aerolinea = aerolinea;
        _archivo = archivo;
    }

    public void Mostrar()
    {
   
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("-----BIENVENIDO A QUALITYFLY----- \nA continuación podrá ver las opciones, elija la que desee realizar");
            Console.WriteLine("1. Agregar vuelo");
            Console.WriteLine("2. Registrar pasajeros");
            Console.WriteLine("3. Ocupación media");
            Console.WriteLine("4. Vuelo mayor ocupación");
            Console.WriteLine("5. Buscar vuelo");
            Console.WriteLine("6. Listar vuelos");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= 7)
            {
                continuar = EjecutarOpcion(opcion);
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                Console.ReadKey();
            }
        }
    }

    private bool EjecutarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                _aerolinea.AgregarVuelo();
                break;
            case 2:
                _aerolinea.RegistrarPasajeros();
                break;
            case 3:
                Console.WriteLine("\nOcupación media: " + _aerolinea.OcupacionMedia().ToString("F2") + "%");
                break;
            case 4:
                _aerolinea.MostrarVueloMayorOcupacion();
                break;
            case 5:
                BuscarVuelo();
                break;
            case 6:
                _aerolinea.ListarVuelos();
                break;
            case 7:
                _aerolinea.GuardarDatos(_archivo);
                Console.WriteLine("\nDatos guardados. Saliendo.");
                return false;
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar.");
        Console.ReadKey();
        return true;
    }


    private void BuscarVuelo()
    {
        Console.Write("\nIngrese el código de vuelo a buscar: ");
        string codigoVuelo = Console.ReadLine();
        Vuelo vuelo = _aerolinea.BuscarVuelo(codigoVuelo);

        if (vuelo != null)
        {
            Console.WriteLine("\nVuelo encontrado: " + vuelo.Codigo + ", Ocupación: " + vuelo.Ocupacion.ToString("F2") + "%");
        }
        else
        {
            Console.WriteLine("\nVuelo no encontrado.");
        }
        Console.ReadKey();
    }
}
