using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro Tab, Cor Cor)
        {
            this.posicao = null;
            this.cor = Cor;
            this.qtdMovimentos = 0;
            this.tab = Tab;
        }
    }
}
