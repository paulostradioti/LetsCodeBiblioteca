using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeBiblioteca.Models.Entidades
{
    public class EntidadeBase
    {
        public string Id { get; set; }
        public EntidadeBase()
        {

            Id = Guid.NewGuid().ToString();
                 
        }
    }
}
