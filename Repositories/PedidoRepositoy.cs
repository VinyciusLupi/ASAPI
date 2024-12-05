using ASAPI.Models;

public class PedidoRepository : IPedidoRepository //fornece a lógica para interagir com o banco de dados em operações relacionadas à entidade Pedido
{

    private readonly AppDbContext _context;
    public PedidoRepository(AppDbContext context) //O AppDbContext é injetado no construtor, permitindo acesso ao banco de dados configurado.
    {
        _context = context;
    }

    public Pedidos Delete(int id)
    {
        var pedidos = _context.Pedido.Find(id);
        if(pedidos == null)
        return pedidos;

    _context.Pedido.Remove(pedidos);
    _context.SaveChanges();
    return pedidos;
    }

    public Pedidos Get(int id)
    {
        return _context.Pedido.Find(id);
    }

    public List<Pedidos> GetAll()
    {
        return _context.Pedido.ToList();
    }

    public void Post(Pedidos pedidos)
    {
        _context.Pedido.Add(pedidos);
        _context.SaveChanges();
    }

    public Pedidos Put(int id, Pedidos pedidosAtualizado)
    {
        var pedidos = _context.Pedido.Find(id);
        if(pedidos == null)
            return pedidos;

        pedidos.Id = pedidosAtualizado.Id;
        pedidos.ValorTotal = pedidosAtualizado.ValorTotal;

        _context.SaveChanges();
        return pedidos;
    }
}