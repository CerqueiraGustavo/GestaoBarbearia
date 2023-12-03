namespace GestaoBarbearia.Web.Models
{
    public class AgendamentoModel : BaseModel
    {
        public string Cliente { get; set; }
        public DateTime DataAgendamento { get; set;}
        public string Descricao { get; set; }
        public double Preco { get; set; }
    }
}
