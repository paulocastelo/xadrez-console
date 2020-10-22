﻿using tabuleiro;
namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "C";
        }
        public override bool[,] movimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }
    }
}
