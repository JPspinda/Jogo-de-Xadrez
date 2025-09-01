namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QndMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tab = tabuleiro;
            QndMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQndMovimentos()
        {
            QndMovimentos++;
        }
    }
}
