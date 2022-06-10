using PessoaCadastro.Models;

namespace PessoaCadastro.Repoitorios
{
    public interface IPessoaRepositorio
    {
        PessoaModel CadastrarPessoa(PessoaModel pessoa);

    }
}
