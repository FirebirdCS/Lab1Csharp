using Lab1.Edu.Kinal.Lab.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        LlamadaLocal local = new LlamadaLocal("33126579","45123456",120);
        LlamadaInterior interiorUno = new LlamadaInterior("54878940","57489450",65,2);
        LlamadaInterior interiorDos = new LlamadaInterior("54878940","57489447",84,1);
        LlamadaInterior interiorTres = new LlamadaInterior("54878940","57489487",35,3);

        Llamada centralTelefonica = new LlamadaLocal();

        centralTelefonica.RegistrarLlamada(local);
        centralTelefonica.RegistrarLlamada(interiorUno);
        centralTelefonica.RegistrarLlamada(interiorDos);
        centralTelefonica.RegistrarLlamada(interiorTres);

        Console.WriteLine($"El total de llamadas es:{centralTelefonica.GetTotalLlamadas()}");
        Console.WriteLine($"El total facturado es:{centralTelefonica.GetTotalFacturas()}");

        Console.ReadKey();

    }
}