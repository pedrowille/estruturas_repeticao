﻿using System;
using System.Collections.Generic;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
// for (int i=0; i<10; i++)
    // Console.WriteLine("O valor de I é {i}");
int contador =0;
        while (contador <5)
        {
Console.WriteLine($"O contador do while é: {contador}");
contador++;        
        }
do
        {
            Console.WriteLine($"O valor do contador é {contador}");
        contador++;
        } while (contador <=10);
 List<string> listaNomes= new ();      
listaNomes.Add("Paulo Ponciano");
listaNomes.Add("Jefferson");
listaNomes.Add("rubens");
listaNomes.Add("Marcos");
listaNomes.Add("Luciane");
listaNomes.Add("Mais um monte de nomes aleatórios.");
foreach (string nome in listaNomes)
{
Console.WriteLine($"O nome da lista é: {nome}");
}        
        try
        {
Console.WriteLine("Digite um número:");
        int numero=Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
Console.WriteLine($"Erro: {ex.Message}");
        }
        }
    }
}