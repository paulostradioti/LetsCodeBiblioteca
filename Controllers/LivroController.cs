using LetsCodeBiblioteca.Models.Contracts.Services;
using LetsCodeBiblioteca.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            try
            {
                var livros = _livroService.Listar();
                return View(livros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome, Autor, Editora, Categoria, Ano")] LivroDto livro)
        {

            try
            {
                _livroService.Cadastrar(livro);

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult Edit(int id)  //Edit para pesquisar atualização
        {
            //if (string.IsNullOrEmpty(id))
            //    return NotFound();

            var livro = _livroService.PesquisarPorId(id);

            if (livro == null)
                return NotFound();

            return View(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Nome, Autor Editora, Categoria, Ano")] LivroDto livro)
        {
            //if (string.IsNullOrEmpty(livro.Id))
            //    return NotFound();

            try
            {
                _livroService.Atualizar(livro);

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public IActionResult Details(int id)
        {
            //if (string.IsNullOrEmpty(id))
            //    return NotFound();

            var livro = _livroService.PesquisarPorId(id);

            if (livro == null)
                return NotFound();

            return View(livro);
        }

        public IActionResult Delete(int id)
        {
            //if (string.IsNullOrEmpty(id))
            //    return NotFound();

            var livro = _livroService.PesquisarPorId(id);

            if (livro == null)
                return NotFound();

            return View(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("Id, Nome, Autor Editora, Categoria, Ano")] LivroDto livro)
        {


            _livroService.Excluir(livro.Id);

            return RedirectToAction("List");


        }

    }
}
