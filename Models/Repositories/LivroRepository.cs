using LetsCodeBiblioteca.Models.Contracts.Contexts;
using LetsCodeBiblioteca.Models.Contracts.Repositories;
using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly IContextData _contextData; //criação de um objeto

        public LivroRepository(IContextData contextData)//injeção de dependencia dentro do repositório de livro
        {
            _contextData = contextData;
        }
        public void Atualizar(LivroDto livro)
        {
            _contextData.AtualizarLivro(livro);
        }

        public void Cadastrar(LivroDto livro)
        {
            _contextData.CadastrarLivro(livro);
        }

        public void Excluir(int id)
        {
            _contextData.ExcluirLivro(id);
        }

        public List<LivroDto> Listar()
        {
            return _contextData.ListarLivro();
        }

        public LivroDto PesquisarPorId(int id)
        {
            return _contextData.PesquisarLivroPorId(id);
        }
    }
}
