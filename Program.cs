using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace _5.operaciones_con_fracciones
{
    class Fraction //Las clases se declaran mediante la palabra clave class
    {
        public int Numerator { get; set; } //El acceso público es el nivel de acceso más permisivo.
        public int Denominator { get; set; } //El acceso público es el nivel de acceso más permisivo.

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b) //El método es estático. Que un miembro de una clase sea estático quiere decir que todas las instancias de esa clase comparten ese miembro en concreto
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba primera fraccion (numerador/denominador):");
            string[] input1 = Console.ReadLine().Split('/');
            Fraction a = new Fraction(int.Parse(input1[0]), int.Parse(input1[1]));

            Console.WriteLine("Escriba segunda fraccion (numerador/denominador):");
            string[] input2 = Console.ReadLine().Split('/');
            Fraction b = new Fraction(int.Parse(input2[0]), int.Parse(input2[1]));

            Console.WriteLine("Elija operacion (+, -, *, /):");
            string operation = Console.ReadLine();

            Fraction result = new Fraction(0, 1);
            switch (operation) //selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión.
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }

            Console.WriteLine("Result: {0}/{1}", result.Numerator, result.Denominator);
            
            Console.ReadLine(); //imprimir el resultado
        }
    }
}
