using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge1.Models;


namespace Challenge1.Controllers
{
    class ProdutoController : Controller
    {

        // CRIANDO UMA LISTA QUE TERÁ ARMAZENAMENTO EM MEMÓRIA, SIMULANDO O BANCO DE DADOS 
        private static IList<Produto> _estoque = new List<Produto>();

        private static int index;




    }
}
