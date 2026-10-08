using System;

Console.WriteLine("SISTEMA DE MONITOREO DE TEMPERATURA DE MOTOR");
Console.WriteLine();

// Creacion del objeto a partir de la clase SensorTemperatura
SensorTemperatura sensor1 = new SensorTemperatura();

// Método para capturar las 5 mediciones de temperatura del motor
Console.WriteLine("Por favor, ingrese las 5 mediciones de temperatura:");
for (int i = 0; i < sensor1.Lecturas.Length; i++)
{
    Console.Write($"Lectura #{i + 1} (°C): ");
    sensor1.Lecturas[i] = Convert.ToDouble(Console.ReadLine());
}

// Creación de MÉTODOS
double promedioObtenido = sensor1.CalcularPromedio();
string estadoMotor = sensor1.ObtenerEstado();

// Mostrar resultados con unidades físicas
Console.WriteLine();
Console.WriteLine($"Promedio de lecturas: {promedioObtenido:F2}°C");
Console.WriteLine($"Estado de diagnóstico: {estadoMotor}");


// DEFINICIÓN DE LA CLASE
class SensorTemperatura
{
    // PROPIEDADES (Arreglo para almacenar las 5 lecturas)
    public double[] Lecturas { get; set; } = new double[5];

    // MÉTODOS
    // Método para calcular el promedio de las lecturas mediante un ciclo for
    public double CalcularPromedio()
    {
        double suma = 0;
        for (int i = 0; i < Lecturas.Length; i++)
        {
            suma += Lecturas[i];
        }
        return suma / Lecturas.Length;
    }

    // Método para determinar el estado según el promedio de temperatura
    public string ObtenerEstado()
    {
        if (CalcularPromedio() <= 70.0)
        {
            return "NORMAL";
        }
        else
        {
            return "ALERTA DE TEMPERATURA";
        }
    }
}