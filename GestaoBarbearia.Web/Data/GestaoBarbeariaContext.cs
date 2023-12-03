using GestaoBarbearia.Web.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace GestaoBarbearia.Web.Data
{
    public class GestaoBarbeariaContext : DbContext
    {
        public GestaoBarbeariaContext(DbContextOptions<GestaoBarbeariaContext> options) : base(options) { }

        public DbSet<AgendamentoModel> Agendamento { get; set; }
    }
}
