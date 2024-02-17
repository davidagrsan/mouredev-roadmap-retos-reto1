using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reto 1

            // Mostrar todos los operadores del lenguaje y un ejemplo de ellos

            MostrarOperadores();
            Console.ReadKey();

            // Reto 1: Extra

            // Crear un programa por consola que imprima todos los números comprendidos entre 10 y 55 incluidos,
            // solo los pares, y que no son ni el 16 ni múltiples de 3

            Console.Clear();
            Reto1Extra();
            Console.ReadKey();
        }

        static void MostrarOperadores()
        {
            // Operadores aritméticos: realizan operaciones matemáticas.
            int a = 10;
            int b = 3;
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {a / b}");
            Console.WriteLine($"Módulo: {a % b}");
            Console.WriteLine($"Incremento: {a++}");
            Console.WriteLine($"Decremento: {b--}");

            // Operadores lógicos: realizan operaciones lógicas entre valores booleanos.
            bool x = true;
            bool y = false;
            Console.WriteLine($"AND lógico: {x && y}");
            Console.WriteLine($"OR lógico: {x || y}");
            Console.WriteLine($"Negación lógica: {!x}");

            // Operadores de comparación: comparan dos valores y devuelven un valor booleano.
            int num1 = 5;
            int num2 = 7;
            Console.WriteLine($"Igual a: {num1 == num2}");
            Console.WriteLine($"No igual a: {num1 != num2}");
            Console.WriteLine($"Mayor que: {num1 > num2}");
            Console.WriteLine($"Menor que: {num1 < num2}");
            Console.WriteLine($"Mayor o igual que: {num1 >= num2}");
            Console.WriteLine($"Menor o igual que: {num1 <= num2}");

            // Operadores de asignación: asignan valores a variables.
            int variable = 10;
            variable += 5;
            variable -= 3;
            variable *= 2;
            variable /= 4;
            variable %= 3;
            Console.WriteLine($"Valor de la variable: {variable}");

            // Operadores de identidad: comprueban la identidad de un objeto.
            object obj = "cadena";
            Console.WriteLine($"¿El objeto es un string? {obj is string}");
            Console.WriteLine($"¿El objeto no es un string? {obj is not string}");

            // Operadores de pertenencia: comprueban si un objeto es miembro de un tipo.
            object objeto = "cadena";
            string cadena = objeto as string;
            Console.WriteLine($"El objeto es de tipo string: {cadena}");

            // Operadores de bits: realizan operaciones a nivel de bits.
            int num3 = 5;
            int num4 = 3;
            Console.WriteLine($"AND a nivel de bits: {num3 & num4}");
            Console.WriteLine($"OR a nivel de bits: {num3 | num4}");
            Console.WriteLine($"XOR a nivel de bits: {num3 ^ num4}");
            Console.WriteLine($"NOT a nivel de bits: {~num3}");
            Console.WriteLine($"Desplazamiento a la izquierda: {num3 << 2}");
            Console.WriteLine($"Desplazamiento a la derecha: {num3 >> 1}");
        }

        static void Reto1Extra()
        {
            // Números comprendidos entre 10 y 55 incluidos
            for (int i = 10; i <= 55; i++)
            {
                // Números pares, que no sean ni el 16 ni múltiplos de 3
                if ((i % 2 == 0) && (i != 16) && (i % 3 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
