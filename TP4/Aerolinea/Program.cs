using System;

class Program
{
    static void Main()
    {
        string archivo = "aerolinea.xml";
        Aerolinea aerolinea = new Aerolinea();

        try
        {
            aerolinea.CargarDatos(archivo);
            Console.WriteLine("Datos cargados correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al cargar los datos: " + ex.Message);
            return;
        }

        Menu menu = new Menu(aerolinea, archivo);
        menu.Mostrar();
    }
}
