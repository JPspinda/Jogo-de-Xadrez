using System;
using Jogo_de_Xadrez;
using tabuleiro;
using xadrez;
using Xadrez;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args) 
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}