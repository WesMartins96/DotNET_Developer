using Microsoft.EntityFrameworkCore;
using Projeto_API_Agendamento_De_Tarefas.Models;

namespace Projeto_API_Agendamento_De_Tarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
