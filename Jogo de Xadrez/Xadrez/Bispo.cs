using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Pecas(pos) != null && Tab.Pecas(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            return mat;
        }

        private bool _podeMover(Posicao pos)
        {
            Peca p = Tab.Pecas(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
