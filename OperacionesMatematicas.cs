using System;

// Interfaz que define las operaciones matemáticas
public interface IOperaciones
{
    // Suma dos números
    double Sumar(double a, double b);

    // Resta dos números
    double Restar(double a, double b);

    // Multiplica dos números
    double Multiplicar(double a, double b);

    // Divide dos números (manejar la división por cero)
    double Dividir(double a, double b);

    // Calcula el área de un círculo
    double CalcularAreaCirculo(double radio);

    // Calcula el volumen de una esfera
    double CalcularVolumenEsfera(double radio);

    // Calcula la distancia entre dos puntos en un plano cartesiano
    double CalcularDistancia(double x1, double y1, double x2, double y2);
}

// Clase abstracta que implementa la interfaz IOperaciones
public abstract class OperacionesBase : IOperaciones
{
    // Implementación de Sumar
    public virtual double Sumar(double a, double b)
    {
        return a + b;
    }

    // Implementación de Restar
    public virtual double Restar(double a, double b)
    {
        return a - b;
    }

    // Implementación de Multiplicar
    public virtual double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Implementación de Dividir con manejo de división por cero
    public virtual double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        return a / b;
    }

    // Implementación de CalcularAreaCirculo
    public virtual double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    // Implementación de CalcularVolumenEsfera
    public virtual double CalcularVolumenEsfera(double radio)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    // Implementación de CalcularDistancia
    public virtual double CalcularDistancia(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}

// Clase derivada de OperacionesBase
public class OperacionesMatematicas : OperacionesBase
{
    // Puedes sobreescribir métodos si es necesario o agregar funcionalidades específicas
    
    // Ejemplo de método adicional
    public double CalcularPotencia(double baseNumero, double exponente)
    {
        return Math.Pow(baseNumero, exponente);
    }

    // Método de ejemplo para demostrar el uso de la clase
    public void MostrarEjemplos()
    {
        Console.WriteLine($"Suma: {Sumar(5, 3)}");
        Console.WriteLine($"Resta: {Restar(10, 4)}");
        Console.WriteLine($"Multiplicación: {Multiplicar(6, 7)}");
        Console.WriteLine($"División: {Dividir(15, 3)}");
        Console.WriteLine($"Área de Círculo (radio 5): {CalcularAreaCirculo(5)}");
        Console.WriteLine($"Volumen de Esfera (radio 3): {CalcularVolumenEsfera(3)}");
        Console.WriteLine($"Distancia entre (0,0) y (3,4): {CalcularDistancia(0, 0, 3, 4)}");
    }
}

// Clase principal para demostración
class Program
{
    static void Main(string[] args)
    {
        OperacionesMatematicas operaciones = new OperacionesMatematicas();
        operaciones.MostrarEjemplos();
    }
}