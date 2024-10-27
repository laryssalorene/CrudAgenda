using iniciandoAPIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace iniciandoAPIs.Context
{
    /// <summary>
    /// a classe dbcontext é do pacote entityframeworkcore
    /// Esse context faz a conexão com o banco de dados
    /// '' faz a ligaçao com o db
    /// </summary>
    public class AgendaContext : DbContext
    {
        //AgendaContext(DbContextOptions<AgendaContext> options)
        //recebe a conexao do banco e 
        //vai passar para o base(options), 
        //ou seja,a classe pai DbContext
        // o Dbcontext q gerencia a conexao com  banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        //propriedade que se refere a uma entidade
        //entidade enquanto uma tabela no db e 
        //uma classe no program
        public DbSet<Contato> Contatos { get; set; }
    }
}

//lembrar q é preciso informar a 
//conexao com o db nos arquivos
//appsettings.json (p/ produção) e
//appsettings.Development.json (teste)