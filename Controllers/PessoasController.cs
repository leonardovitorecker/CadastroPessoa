using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PessoaCadastro.database;
using PessoaCadastro.Models;
using PessoaCadastro.Repoitorios;

namespace PessoaCadastro.Controllers
{
    public class PessoasController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly Context _bancocontext;

        public PessoasController( IPessoaRepositorio pessoaRepositorio,Context context)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _bancocontext = context;
        }
        public IActionResult Cadastro()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Cadastro(PessoaModel pessoa)
        {
            _pessoaRepositorio.CadastrarPessoa(pessoa);
            return View(pessoa);
        }
    }
}
