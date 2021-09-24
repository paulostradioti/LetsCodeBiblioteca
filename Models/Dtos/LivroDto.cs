using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Dtos
{
    public class LivroDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public DateTime Ano { get; set; }

        public LivroDto(int id, string nome, string autor, string editora, DateTime ano)
            :this(nome, autor, editora, ano)
        {
            this.Id = id;
        }

        public LivroDto(string nome, string autor, string editora, DateTime ano)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Editora = editora;
            this.Ano = ano;


        }
    }

    
}
