using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    // AgendaContext: classe de contexto do banco de dados, que herda de DbContext
    // DbContext: Essa classe é responsável por gerenciar a conexão e operações com o banco
    public class AgendaContext : DbContext
    {
        // Construtor que recebe as opções de configuração do contexto de DBContextOptions
        // Essas opções geralmente incluem a string de conexão e o provedor (ex: SQL Server)
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
    
        // Cada prop DbSet<> representa uma tabela no banco de dados
        // Cada instância de 'Contato' será uma linha na tabela
        public DbSet<Contato> Contatos { get; set; }
    }

}