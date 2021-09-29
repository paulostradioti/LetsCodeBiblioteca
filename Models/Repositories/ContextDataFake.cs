using LetsCodeBiblioteca.Models.Contracts.Contexts;
using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Repositories
{

    public class ContextDataFake : IContextData // Implementando a interface criada para trabalhar com qualquer BD
    {
        private readonly Context _dbContext;
        private static List<LivroDto> livros; // vai ter os proprios métodos que vão tratar essa informação, nomeado livro por ser privado

        public ContextDataFake(Context dbContext)
        {
            _dbContext = dbContext;
            livros = new List<LivroDto>();
            InitializeData();
        }

        public void AtualizarLivro(LivroDto livro)
        {
            var objPesquisa = PesquisarLivroPorId(livro.Id);
            livros.Remove(objPesquisa);

            objPesquisa.Nome = livro.Nome;
            objPesquisa.Autor = livro.Autor;
            objPesquisa.Editora = livro.Editora;
            objPesquisa.Categoria = livro.Categoria;
            objPesquisa.Ano = livro.Ano;

            CadastrarLivro(objPesquisa);
        }

        public void CadastrarLivro(LivroDto livro)
        {
            try
            {
                _dbContext.Add(livro);
                _dbContext.SaveChanges();

                livros.Add(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(int id)
        {
            var objPesquisa = PesquisarLivroPorId(id);
            livros.Remove(objPesquisa);
        }

        public List<LivroDto> ListarLivro()
        {
           
            return livros
                .OrderBy(p => p.Nome)
                .ToList();
        }

        public LivroDto PesquisarLivroPorId(int id)
        {
           return livros.FirstOrDefault(p => p.Id == id);
            
        }

        private void InitializeData() //nao vai ser mais do tipo static
        {
            
            var livro = new LivroDto("Implementando Domain-Driven Design", "Vaugh Vernon", "Alta Books", "Informatica", 1990 );
            livros.Add(livro);

             livro = new LivroDto("Implementando ", "Eric Vainos", "Alta Books", "Romance", 2001);
            livros.Add(livro);

            livro = new LivroDto("Domein design", " Vernon", "Alta Books", "Aventura", 2002);
            livros.Add(livro);

            livro = new LivroDto("Design", "Vaugh ", "Alta Books", "Drama", 1999);
            livros.Add(livro);
        }
    }
}
