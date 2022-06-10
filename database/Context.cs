using Microsoft.EntityFrameworkCore;
using PessoaCadastro.Models;

namespace PessoaCadastro.database
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opcoes)
: base(opcoes)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }


        public DbSet<PessoaModel> pessoas { get; set; }

    }
}
