﻿using ArvoreCustom.Services;
using ArvoreCustom.Models;

class Program
{
    static void Main()
    {
        var builder = new TreeBuilder();

        // =====================
        // Cenário 1
        // =====================
        int[] arr1 = { 3, 2, 1, 6, 0, 5 };
        var tree1 = builder.BuildTree(arr1);

        Console.WriteLine("Cenário 1");
        Console.WriteLine($"Array de entrada: [{string.Join(", ", arr1)}]");
        Console.WriteLine($"Raiz: {arr1.Max()}");
        Console.WriteLine($"Galhos da esquerda: {string.Join(", ", arr1.Take(Array.IndexOf(arr1, arr1.Max())))}");
        Console.WriteLine($"Galhos da direita: {string.Join(", ", arr1.Skip(Array.IndexOf(arr1, arr1.Max()) + 1))}");
        Console.WriteLine();

        builder.PrintTree(tree1);
        Console.WriteLine("\n");

        // =====================
        // Cenário 2
        // =====================
        int[] arr2 = { 7, 5, 13, 9, 1, 6, 4 };
        var tree2 = builder.BuildTree(arr2);

        Console.WriteLine("Cenário 2");
        Console.WriteLine($"Array de entrada: [{string.Join(", ", arr2)}]");
        Console.WriteLine($"Raiz: {arr2.Max()}");
        Console.WriteLine($"Galhos da esquerda: {string.Join(", ", arr2.Take(Array.IndexOf(arr2, arr2.Max())))}");
        Console.WriteLine($"Galhos da direita: {string.Join(", ", arr2.Skip(Array.IndexOf(arr2, arr2.Max()) + 1))}");
        Console.WriteLine();

        builder.PrintTree(tree2);
    }
}
