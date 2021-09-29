using LetsCodeBiblioteca.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Dtos
{
    public class LivroDto : EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Categoria { get; set; }
        public int Ano { get; set; }

        public LivroDto()
        {

        }

        public LivroDto(int id, string nome, string autor, string editora, string categoria, int ano)
            : this(nome, autor, editora, categoria, ano)
        {
            this.Id = id;
        }

        public LivroDto(string nome, string autor, string editora, string categoria, int ano)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Editora = editora;
            this.Categoria = categoria;
            this.Ano = ano;


        }
    }


}
