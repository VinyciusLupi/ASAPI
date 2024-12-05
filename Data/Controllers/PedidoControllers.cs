using ASAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IPedidoRepository _repository;

    public PedidosController(IPedidoRepository repository)
    {   
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Pedidos>> GetAll()
    {
        var pedidos = _repository.GetAll();
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    public ActionResult<Pedidos> Get(int id)
    {
        var pedidos = _repository.GetAll().FirstOrDefault(p => p.Id == id);

        if (pedidos == null)
        {
            return NotFound();
        }

        return Ok(pedidos);
    }

    [HttpPost]
    public ActionResult Post(Pedidos pedidos)
    {
        _repository.Post(pedidos);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Pedidos pedidosAtualizado)
    {
        var pedidos = _repository.Put(id, pedidosAtualizado);
        if (pedidos == null)
        {
            return NotFound();
        }
        return Ok(pedidos);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var pedidos = _repository.Delete(id);

        if (pedidos == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
}