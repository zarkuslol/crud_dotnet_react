namespace CrudTest.Services;

using CrudTest.Models;

public class PessoaService : ServiceCollection {
    public PessoaService() {}

    public string Greet() {
        return "Hello from Service Layer";
    }

    public Pessoa CriarPessoa(Pessoa pessoa) {
        return pessoa;
    }

    public List<Pessoa> ListarPessoas() {
        return new List<Pessoa>();
    }

    public long ObterPessoaPorId(long id) {
        return id;
    }

    public Pessoa AtualizarPessoa(Pessoa pessoa) {
        return pessoa;
    }

    public long ExcluirPessoa(long id) {
        return id;
    }
}
