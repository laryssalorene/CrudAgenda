using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
 
namespace iniciandoAPIs.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
        public bool Ativo { get; set; }
    }

}

// com base nesta classe contato gerou-se uma migration.
//essa migration transformou esta classe em um codigo
//presente no arquivo 20241017011621_CriacaoTabelaContato
//para poder mapear a tabela e ao aplicar,executar 
// a migration ele automaticamente criou os comandos lá escritos
//no banco de dados.