namespace CrudTest.Services;

using CrudTest.Models;
using CrudTest.Repositories;

public interface IPessoaService {
    string Greet();
    List<Pessoa> ListarPessoas();
    Pessoa ObterPessoaPorId(long id);
    string CriarPessoa(Pessoa pessoa);
    string AtualizarPessoa(Pessoa pessoa);
    string ExcluirPessoa(long id);
}

public class PessoaService : IPessoaService {
    private readonly IPessoaRepository _repository;

    public PessoaService(IPessoaRepository repository) {
        _repository = repository;
    }

    public string Greet() {
        return "Hello from Service Layer";
    }

    public List<Pessoa> ListarPessoas() {
        return _repository.ListarPessoas();
    }

    public Pessoa ObterPessoaPorId(long id) {
        return _repository.ObterPessoaPorId(id);
    }

    public string CriarPessoa(Pessoa pessoa) {
        try {
            _repository.CriarPessoa(pessoa);
            return "User created successfully";
        } catch (Exception error) {
            return $"Error: {error}";
        }
    }

    public string AtualizarPessoa(Pessoa pessoa) {
        try {
            _repository.AtualizarPessoa(pessoa);;
            return "User updated successfully";
        } catch (Exception error) {
            return $"Error: {error}";
        }
    }

    public string ExcluirPessoa(long id) {
        try {
            _repository.ExcluirPessoa(id);
            return "User removed successfully";
        } catch (Exception error) {
            return $"Error: {error}";
        }
    }
}
