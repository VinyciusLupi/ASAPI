using ASAPI.Models;

public interface IFornecedorRepository
{
    public List<Fornecedor> GetAll();
    public Fornecedor Get(int id);
    public void Post(Fornecedor Fornec);
    public Fornecedor Put(int id, Fornecedor fornecedoratualizado);
    public Fornecedor Delete(int id);
}