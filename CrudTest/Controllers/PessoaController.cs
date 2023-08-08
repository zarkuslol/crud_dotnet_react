using Microsoft.AspNetCore.Mvc;
using CrudTest.Services;
namespace CrudTest.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase {
    private readonly PessoaService _service;

    public PessoaController() {
        _service = new PessoaService();
    }

    [HttpGet]
    public string Greet() {
        return _service.Greet();
    }
}
