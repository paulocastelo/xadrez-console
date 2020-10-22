namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null; //It is a function of Tabuleiro
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        protected bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
