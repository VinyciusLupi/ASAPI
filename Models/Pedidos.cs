namespace ASAPI.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Decimal ValorTotal { get; set; }
        public string Status { get; set; } 
        public string Descricao { get; set; }
    }
} 