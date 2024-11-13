using System;

[Serializable]
public class Vuelo
{
    public string Codigo { get; set; }
    public DateTime Salida { get; set; }
    public DateTime Llegada { get; set; }
    public string Piloto { get; set; }
    public string Copiloto { get; set; }
    public int CapacidadMaxima { get; set; }

    private int _registrados;

    public int Registrados
    {
        get { return _registrados; }
    }

    public double Ocupacion
    {
        get
        {
            if (CapacidadMaxima > 0)
            {
                return (double)_registrados / CapacidadMaxima * 100;
            }
            return 0;
        }
    }

    public void RegistrarPasajeros(int cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad de pasajeros debe ser mayor que cero.");
            return;
        }

        if (_registrados + cantidad > CapacidadMaxima)
        {
            Console.WriteLine("La cantidad de pasajeros excede la capacidad máxima.");
            return;
        }

        _registrados += cantidad;
        Console.WriteLine(cantidad + "los pasajeros fueron registrados exitosamente.");
    }

    public void CancelarPasajeros(int cantidad)
    {
        if (cantidad <= 0)
        {
            Console.WriteLine("La cantidad de pasajeros a cancelar debe ser mayor que cero.");
            return;
        }

        if (cantidad > _registrados)
        {
            Console.WriteLine("No se pueden cancelar más pasajeros de los que están registrados.");
            return;
        }

        _registrados -= cantidad;
        Console.WriteLine(cantidad + "La cantidad de pasajeros fue cancelada exitosamente.");
    }
}
