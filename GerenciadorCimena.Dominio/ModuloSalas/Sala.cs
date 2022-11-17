﻿using GerenciadorCimena.Dominio.Compartilhado;
using GerenciadorCimena.Dominio.ModuloSessoes;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCimena.Dominio.ModuloSalas
{
    public class Sala : EntidadeBase<Sala>
    {      
               

        public Sala()
        {           

        }
        public Sala(string nome, int quantidadeAssentos)
        {
            Nome = nome;
            QuantidadeAssentos = quantidadeAssentos;
        }

        public string Nome { get; set; }

        public int QuantidadeAssentos { get; set; }

        public List<Sessao> Sessoes { get; set; }


      

        public override void Atualizar(Sala registro)
        {
            Id = registro.Id;
            Nome = registro.Nome;
            QuantidadeAssentos = registro.QuantidadeAssentos;            
        }

        public override bool Equals(object obj)
        {
            return obj is Sala sala &&
                Id == sala.Id &&
                Nome == sala.Nome &&
                QuantidadeAssentos == sala.QuantidadeAssentos;
        }       

    }

   
}
