using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeJogosForms.Classes
{
    class Jogo
    {
        public string titulo { get;  private set; }
        public string ano { get; private set; }
        public string genero { get; private set; }
        public string maxJogadores { get; private set; }
        public string metaCritic { get; private set; }

        public Jogo(string titulo, string ano, string genero, string maxJogadores, string metaCritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metaCritic = metaCritic;
        }
    }
}
