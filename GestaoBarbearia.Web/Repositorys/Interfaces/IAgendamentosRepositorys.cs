using GestaoBarbearia.Web.Models;

namespace GestaoBarbearia.Web.Repositorys.Interfaces
{
    public interface IAgendamentosRepositorys
    {
        Task<List<AgendamentoModel>> GetAllAgendamentos();
        Task<AgendamentoModel> GetAgendamentoById(int id);
        Task<AgendamentoModel> AddAgendamento(AgendamentoModel agendamentoModel);
        Task<AgendamentoModel> AltAgendamento(AgendamentoModel agendamentoModel, int id);
        Task<bool> RemoveAgendamento(int id);
    }
}
