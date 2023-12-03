using GestaoBarbearia.Web.Models;
using GestaoBarbearia.Web.Repositorys;
using GestaoBarbearia.Web.Repositorys.Interfaces;
using GestaoBarbearia.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GestaoBarbearia.Web.Controllers
{
    public class AgendamentoController : Controller
    {
        private IAgendamentosRepositorys _agendamentosRepositorys;

        public AgendamentoController(IAgendamentosRepositorys agendamentosRepositorys)
        {
            _agendamentosRepositorys = agendamentosRepositorys;
        }

        public async Task<IActionResult> Index()
        {
            List<AgendamentoModel> agendamentos = await _agendamentosRepositorys.GetAllAgendamentos();

            return View(agendamentos);
        }

        [HttpGet]
        public async Task<IActionResult> AdicionarAgendamento()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarAgendamento(AgendamentoViewModel agendamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                AgendamentoModel agendamentoModel = new AgendamentoModel();
                agendamentoModel.Cliente = agendamentoViewModel.Cliente;
                agendamentoModel.DataAgendamento = agendamentoViewModel.DataAgendamento;
                agendamentoModel.Descricao = agendamentoViewModel.Descricao;
                agendamentoModel.Preco = agendamentoViewModel.Preco;

                _agendamentosRepositorys.AddAgendamento(agendamentoModel);

                return RedirectToAction(nameof(Index));
            }

            return View("AdicionarAgendamento");

        }
    }
}
