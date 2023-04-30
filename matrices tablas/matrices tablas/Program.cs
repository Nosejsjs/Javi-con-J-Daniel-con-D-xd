using System;
namespace matricesdetablasdemultiplicar
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int messi = int.Parse(Console.ReadLine());

            int[,] matriz = new int[messi, messi];

            for (int i = 0; i < messi; i++)
            {
                for (int j = 0; j < messi; j++)
                {
                    matriz[i, j] = (i + 1) * (j + 1);
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < messi; i++)
            {
                for (int j = 0; j < messi; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}