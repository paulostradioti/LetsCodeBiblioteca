using LetsCodeBiblioteca.Models.Contracts.Repositories;
using LetsCodeBiblioteca.Models.Contracts.Services;
using LetsCodeBiblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Atualizar(LivroDto livro)
        {
            try
            {
                _livroRepository.Atualizar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(LivroDto livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDto> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        public LivroDto PesquisarPorId(int id)
        {
            try
            {
                return _livroRepository.PesquisarPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LivroDto Detalhes(int id)
        {
            try
            {
                return _livroRepository.PesquisarPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                 _livroRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
