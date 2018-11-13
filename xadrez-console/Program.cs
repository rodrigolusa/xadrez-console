﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Branco, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preto, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Branco, tab), new Posicao(2, 4));
                tab.colocarPeca(new Rei(Cor.Preto, tab), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
 