﻿using System.ComponentModel;

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
        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }
        public bool existemMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j]) // or simply "if (mat[i, j] == true)"
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
