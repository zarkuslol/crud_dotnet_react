using Microsoft.AspNetCore.Mvc;
using CrudTest.Services;
using CrudTest.Models;

namespace CrudTest.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PessoaController : ControllerBase {
    private readonly IPessoaService _service;

    public PessoaController(IPessoaService service) {
        _service = service;
    }

    [HttpGet]
    [Route("greet")]
    public string Greet() {
        return _service.Greet();
    }

    [HttpGet]
    public List<Pessoa> ListarPessoas() {
        return _service.ListarPessoas();
    }

    [HttpGet("{id}")]
    public Pessoa ObterPessoaPorId(long id) {
        return _service.ObterPessoaPorId(id);
    }

    [HttpPost]
    public string CriarPessoa(Pessoa pessoa) {
        return _service.CriarPessoa(pessoa);
    }

    [HttpPut]
    public string AtualizarPessoa(Pessoa pessoa) {
        return _service.AtualizarPessoa(pessoa);
    }

    [HttpDelete("{id}")]
    public string ExcluirPessoa(long id) {
        return _service.ExcluirPessoa(id);
    }
}
