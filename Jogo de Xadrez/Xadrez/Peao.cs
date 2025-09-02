using tabuleiro;
using Xadrez;

namespace xadrez
{
    class Peao : Peca
    {
        private PartidaDeXadrez Partida { get; set; }

        public Peao(Cor cor, Tabuleiro tabuleiro, PartidaDeXadrez partida) : base(cor, tabuleiro)
        {
            Partida = partida;
        }

        private bool _existeInimigo(Posicao pos)
        {
            Peca p = Tab.Pecas(pos);
            return p != null && p.Cor != Cor;
        }

        private bool _livre(Posicao pos)
        {
            return Tab.Pecas(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && _livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && _livre(pos) && QndMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && _existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && _existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(esquerda) && _existeInimigo(esquerda) && Tab.Pecas(esquerda) == Partida.VulneravelEnPassant)
                    {
                        mat[esquerda.Linha - 1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(direita) && _existeInimigo(direita) && Tab.Pecas(direita) == Partida.VulneravelEnPassant)
                    {
                        mat[direita.Linha - 1, direita.Coluna] = true;
                    }
                }
            }
            else
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && _livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && _livre(pos) && QndMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && _existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && _existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(esquerda) && _existeInimigo(esquerda) && Tab.Pecas(esquerda) == Partida.VulneravelEnPassant)
                    {
                        mat[esquerda.Linha + 1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(direita) && _existeInimigo(direita) && Tab.Pecas(direita) == Partida.VulneravelEnPassant)
                    {
                        mat[direita.Linha + 1, direita.Coluna] = true;
                    }
                }
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
            return "P";
        }
    }
}
