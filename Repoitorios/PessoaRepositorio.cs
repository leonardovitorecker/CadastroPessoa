using PessoaCadastro.database;
using PessoaCadastro.Models;

namespace PessoaCadastro.Repoitorios
{
    public class PessoaRepositorio:IPessoaRepositorio
    {
        private readonly Context _bancocontext;

        public PessoaRepositorio(Context context)
        {
            _bancocontext = context;
        }

        public PessoaModel CadastrarPessoa(PessoaModel pessoa)
        {
            _bancocontext.pessoas.Add(pessoa);
            _bancocontext.SaveChanges();

            return pessoa;
        }
    }
}
