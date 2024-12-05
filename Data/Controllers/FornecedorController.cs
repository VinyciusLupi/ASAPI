using ASAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController] // Identifica a classe como um controlador de API REST habilitando validações automáticas de modelo e simplificando o processamento de requisições
[Route("[controller]")] //Define a rota base para os endpoints [controller] será substituído pelo nome do controlador Fornecedor
public class FornecedorController : ControllerBase
{
    private readonly IFornecedorRepository _repository;

    public FornecedorController(IFornecedorRepository repository)
    {   
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Fornecedor>> GetAll()
    {
        var produtos = _repository.GetAll();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public ActionResult<Fornecedor> Get(int id)
    {
        var fornec = _repository.GetAll().FirstOrDefault(p => p.Id == id);

        if (fornec == null)
        {
            return NotFound();
        }

        return Ok(fornec);
    }

    [HttpPost]
    public ActionResult Post(Fornecedor fornec)
    {
        _repository.Post(fornec);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornec = _repository.Put(id, fornecedorAtualizado);
        if (fornec == null)
        {
            return NotFound();
        }
        return Ok(fornec);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var fornec = _repository.Delete(id);

        if (fornec == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
}