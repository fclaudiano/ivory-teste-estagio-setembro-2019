﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void criaMatriz (string nome)
        {
            int i = nome.Length;
            string [,] matriz = new string[3, i+2];
            populaMatriz(matriz, i+2, nome);
        }

        static void populaMatriz(string[,] matriz, int controle, string nome)
        {
            int num = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < controle; j++)
                {

                    if (i==1)
                    {
                        if (j==0)
                        {
                            matriz[i, j] = ((controle+1) * 2).ToString();
                        }
                        if (j == controle-1)
                        {
                            matriz[i, j] = (controle+1).ToString();
                            num = (num *2) - 1;
                        }
                    }
                    else
                    {
                        if (i == 2)
                        {
                            matriz[i, j] = (num--).ToString();
                        }
                        else
                        {
                            matriz[i, j] = (num++).ToString();
                        }
                        
                    }
                    
                }
            }

           for (int i = 0 ,j = 1; j < controle-1; j++)
           {
                matriz[1, j] = (nome[i]).ToString(); ;
                i++;
           }
            

            exibirMatriz(matriz,controle);
            Console.ReadKey();
        }

      

        static void exibirMatriz (string [,] matriz, int controle)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < controle; j++)
                {
   
                  Console.Write( matriz[i, j]+"\t");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite seu nome");
            string nome = Console.ReadLine();

            Console.Clear();

            criaMatriz(nome);
            
        }
    }
}