﻿using tabuleiro;
namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "P";
        }
        public override bool[,] movimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }
    }
}
