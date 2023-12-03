namespace GestaoBarbearia.Web.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; } = new DateTime();
        public DateTime? UpdateAt { get; set; }
    }
}
