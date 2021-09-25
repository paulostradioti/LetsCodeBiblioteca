using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Repositories
{
    public class ContextDataFake
    {
        public static List<LivroDto> Livros;

        static ContextDataFake()
        {
            Livros = new List<LivroDto>();
            InitializeData();
        }

        private static void InitializeData()
        {
            
            var livro = new LivroDto("Implementando Domain-Driven Design", "Vaugh Vernon", "Alta Books", "Informatica", 1990 );
            Livros.Add(livro);

             livro = new LivroDto("Implementando ", "Eric Vainos", "Alta Books", "Romance", 2001);
            Livros.Add(livro);

            livro = new LivroDto("Domein design", " Vernon", "Alta Books", "Aventura", 2002);
            Livros.Add(livro);

            livro = new LivroDto("Design", "Vaugh ", "Alta Books", "Drama", 1999);
            Livros.Add(livro);
        }
    }
}
