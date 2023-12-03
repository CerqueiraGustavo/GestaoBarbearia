using GestaoBarbearia.Web.Data;
using GestaoBarbearia.Web.Models;
using GestaoBarbearia.Web.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestaoBarbearia.Web.Repositorys
{
    public class AgendamentosRepositorys : IAgendamentosRepositorys
    {
        private readonly GestaoBarbeariaContext _gestaoBarbeariaContext;

        public AgendamentosRepositorys(GestaoBarbeariaContext gestaoBarbeariaContext)
        {
            _gestaoBarbeariaContext = gestaoBarbeariaContext;
        }

        public async Task<List<AgendamentoModel>> GetAllAgendamentos()
        {
            return await _gestaoBarbeariaContext.Agendamento.ToListAsync();
        }

        public async Task<AgendamentoModel> GetAgendamentoById(int id)
        {
            return await _gestaoBarbeariaContext.Agendamento.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AgendamentoModel> AddAgendamento(AgendamentoModel agendamentoModel)
        {
            await _gestaoBarbeariaContext.Agendamento.AddAsync(agendamentoModel);
            await _gestaoBarbeariaContext.SaveChangesAsync();

            return agendamentoModel;
        }

        public async Task<AgendamentoModel> AltAgendamento(AgendamentoModel agendamentoModel, int id)
        {
            AgendamentoModel agendamentoFound = await GetAgendamentoById(id);

            if (agendamentoFound == null)
            {
                throw new Exception("The Developer was not found.");
            }

            agendamentoFound.Cliente = agendamentoModel.Cliente;
            agendamentoFound.DataAgendamento = agendamentoModel.DataAgendamento;
            agendamentoFound.Descricao = agendamentoModel.Descricao;
            agendamentoFound.Preco = agendamentoModel.Preco;
            agendamentoFound.UpdateAt = DateTime.Now;

            _gestaoBarbeariaContext.Agendamento.Update(agendamentoFound);
            await _gestaoBarbeariaContext.SaveChangesAsync();

            return agendamentoFound;
        }

        public async Task<bool> RemoveAgendamento(int id)
        {
            AgendamentoModel GameFound = await GetAgendamentoById(id);

            if (GameFound == null)
            {
                throw new Exception("The Game was not found.");
            }

            _gestaoBarbeariaContext.Agendamento.Remove(GameFound);
            await _gestaoBarbeariaContext.SaveChangesAsync();

            return true;
        }
    }
}
