using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int Linhas, int Colunas)
        {
            this.linhas = Linhas;
            this.colunas = Colunas;
            this.pecas = new Peca[linhas, colunas];
        }
    }
}
