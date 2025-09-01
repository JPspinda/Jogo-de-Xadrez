
using tabuleiro;
namespace Xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a'); // cada caracter possui um código para representar sua letra, e quando colocamos um caraceter menos 'a' estamos praticamente convertendo eles para numeros
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
