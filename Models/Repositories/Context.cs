using LetsCodeBiblioteca.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Repositories
{
    public class Context : DbContext  //interface do EntityFramework chamada DBcontext
    {
        public DbSet<LivroDto> Livros { get; set; } //Uma tabela chamada Livros

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Método responsável por configurar o Entity Framework
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LetsCodeBiblioteca;Trusted_Connection=True;");// coloca a string de conexão. 
        }

      

    }

 
}
