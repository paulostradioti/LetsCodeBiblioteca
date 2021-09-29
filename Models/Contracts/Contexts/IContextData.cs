using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Contracts.Contexts
{
    public interface IContextData // Interface pra trabalhar com qualquer banco de dados
    {
        void CadastrarLivro(LivroDto livro);
        List<LivroDto> ListarLivro();

        LivroDto PesquisarLivroPorId(int id);
        void AtualizarLivro(LivroDto livro);
        void ExcluirLivro(int id);
    }
}
