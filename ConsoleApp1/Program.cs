using System;

namespace ConsoleApp1
{
    class Program
    {
        static string[,] CriarMatriz(int linhas, int colunas)
        {
            return new string[linhas, colunas];
        }

        static void PopularMatriz(string[,] matriz, string nome)
        {
            int preenchimentoNumerico = 1;

            int quantidadeLinhas = matriz.GetLength(0);
            int quantidadeColunas = matriz.GetLength(1);

            for (int indiceLinha = 0; indiceLinha < quantidadeLinhas; indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < quantidadeColunas; indiceColuna++)
                {
                    bool linhaDoMeio = indiceLinha == 1;
                    bool ultimaLinha = indiceLinha == 2;

                    if (linhaDoMeio)
                    {
                        matriz[indiceLinha, 0] = (preenchimentoNumerico * 2).ToString();

                        int indiceUltimaColuna = quantidadeColunas - 1;

                        matriz[indiceLinha, indiceUltimaColuna] = (preenchimentoNumerico / 2 + 1).ToString();

                        if (indiceColuna == indiceUltimaColuna)
                        {
                            preenchimentoNumerico = (preenchimentoNumerico * 2) - 1;
                        }
                    }
                    else if (ultimaLinha)
                    {
                        matriz[indiceLinha, indiceColuna] = (preenchimentoNumerico--).ToString();
                    }
                    else
                    {
                        matriz[indiceLinha, indiceColuna] = (preenchimentoNumerico++).ToString();
                    }
                }
            }

            for (int indice = 0, colunas = 1; colunas <= nome.Length; colunas++)
            {
                matriz[1, colunas] = (nome[indice]).ToString();
                indice++;
            }
        }


        static void ExibirMatriz(string[,] matriz, int quantidadeColunas)
        {
            for (int indiceLinha = 0; indiceLinha < 3; indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < quantidadeColunas; indiceColuna++)
                {

                    Console.Write(matriz[indiceLinha, indiceColuna] + "\t");

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite seu nome");
            string nome = Console.ReadLine();

            Console.Clear();

            int quantidadeLetrasNome = nome.Length;
            int colunas = quantidadeLetrasNome + 2;
            const int linhas = 3;

            string[,] matriz = CriarMatriz(linhas, colunas);

            PopularMatriz(matriz, nome);

            ExibirMatriz(matriz, colunas);

            Console.ReadKey();
        }
    }
}
