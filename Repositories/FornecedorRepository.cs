using ASAPI.Models;

public class FornecedorRepository : IFornecedorRepository
{

    private readonly AppDbContext _context;
    public FornecedorRepository(AppDbContext context)
    {
        _context = context;
    }

    public Fornecedor Delete(int id)
    {
        var fornec = _context.Fornec.Find(id);
        if(fornec == null)
        return fornec;

    _context.Fornec.Remove(fornec);
    _context.SaveChanges();
    return fornec;
    }

    public Fornecedor Get(int id)
    {
        return _context.Fornec.Find(id);
    }

    public List<Fornecedor> GetAll()
    {
        return _context.Fornec.ToList();
    }

    public void Post(Fornecedor Fornec)
    {
        _context.Fornec.Add(Fornec);
        _context.SaveChanges();
    }

    public Fornecedor Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornec = _context.Fornec.Find(id);
        if(fornec == null)
            return fornec;

        fornec.Id = fornecedorAtualizado.Id;
        fornec.Email = fornecedorAtualizado.Email;
        fornec.Telefone = fornecedorAtualizado.Telefone;
        fornec.Endereco = fornecedorAtualizado.Endereco;

        _context.SaveChanges();
        return fornec;
    }
}