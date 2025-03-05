namespace Prueba;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }

    public override string ToString()
    {
        return Nombre;
    }
  
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}
