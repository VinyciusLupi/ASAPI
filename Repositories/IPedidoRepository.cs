using ASAPI.Models;

public interface IPedidoRepository
{
    public List<Pedidos> GetAll(); 
    public Pedidos Get(int id); //Busca um pedido específico baseado em seu identificador id
    public void Post(Pedidos Pedido); //Adiciona um novo pedido ao sistema.
    public Pedidos Put(int id, Pedidos pedidoatualizado); //Atualiza os dados de um pedido existente
    public Pedidos Delete(int id); //Remove um pedido com base no identificador id

} 