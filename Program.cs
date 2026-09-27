class Program
{
    static void Main()
    {
        Console.Write("Cual es tu nombre?: ");
        string nombre = Console.ReadLine();

        Console.Write("Cual es tu apellido?: ");
        string apellido = Console.ReadLine();

        Console.Write("Cual es tu edad?: ");
        int edad = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Cual es tu altura en metros?: ");
        double altura = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Hola, " + nombre + " " + apellido + "! Tienes " + edad + " años y mides " + altura + " metros.");
    }
}