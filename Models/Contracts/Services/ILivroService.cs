using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Contracts.Services
{
   public interface ILivroService
    {
        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();

       LivroDto PesquisarPorId(int id);
        void Atualizar(LivroDto livro);
        void Excluir(int id);
    }
}
