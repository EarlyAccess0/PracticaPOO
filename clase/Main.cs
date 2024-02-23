using System;

public class PracticaPOO
{
    public static void Main()
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Honda", 2020);
        Coche coche2 = new Coche("Ford", 2018);

        for (int i = 0; i < 2; i++)
        {
            AtenderCoche(garaje, coche1);
            AtenderCoche(garaje, coche2);
        }

        MostrarInformacion(coche1);
        MostrarInformacion(coche2);
    }

    public static void AtenderCoche(Garaje garaje, Coche coche)
    {
        string averia = GenerarAveriaAleatoria();
        double importeAveria = GenerarImporteAveriaAleatorio();

        if (averia == "aceite")
        {
            Motor motor = coche.GetMotor();
            motor.IncrementarLitrosAceite(10);
        }

        if (garaje.AceptarCoche(coche, averia))
        {
            Console.WriteLine($"Atendiendo coche {coche.getMarca()} {coche.getModelo()} - Avería: {averia} - Importe: {importeAveria}");
            garaje.AcumularAveria(importeAveria);
            garaje.DevolverCoche();
        }
        else
        {
            Console.WriteLine($"No se puede atender el coche {coche.getMarca()} {coche.getModelo()} porque ya se está atendiendo otro coche.");
        }
    }

    public static string GenerarAveriaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(3);
        string[] averias = { "aceite", "neumaticos", "frenos" };
        return averias[index];
    }

    public static double GenerarImporteAveriaAleatorio()
    {
        Random random = new Random();
        return random.NextDouble() * 100;
    }

    public static void MostrarInformacion(Coche coche)
    {
        Console.WriteLine($"Información del coche {coche.getMarca()} {coche.getModelo()}:");
        Motor motor = coche.GetMotor();
        Console.WriteLine($"Litros de aceite: {motor.getLitrosDeAceite()}");
        Console.WriteLine($"Importe total de averías: {coche.AcumuladorDeAverias()}");
    }
}






