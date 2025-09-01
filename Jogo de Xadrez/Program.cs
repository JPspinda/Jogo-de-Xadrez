using System;
using Jogo_de_Xadrez;
using JogoDeXadrez.tabuleiro;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}