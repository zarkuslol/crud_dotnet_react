namespace CrudTest.Repositories;

using CrudTest.Models;

public interface IPessoaRepository {
    public void CriarPessoa(Pessoa pessoa);

    public List<Pessoa> ListarPessoas();

    public Pessoa ObterPessoaPorId(long id);

    public void AtualizarPessoa(Pessoa pessoa);

    public void ExcluirPessoa(long id);
}

public class PessoaRepository : IPessoaRepository {
    public readonly DbConfig _dbConfig;

    public PessoaRepository(DbConfig dbConfig) {
        _dbConfig = dbConfig;
    }

    public void CriarPessoa(Pessoa pessoa) {
        _dbConfig.Pessoas.Add(pessoa);
        _dbConfig.SaveChanges();
    }

    public List<Pessoa> ListarPessoas() {
        return _dbConfig.Pessoas.ToList();
    }

    public Pessoa ObterPessoaPorId(long id) {
        return _dbConfig.Pessoas.Find(id);
    }

    public void AtualizarPessoa(Pessoa pessoa) {
        _dbConfig.Pessoas.Update(pessoa);
        _dbConfig.SaveChanges();
    }

    public void ExcluirPessoa(long id) {
        var pessoaToBeDeleted = _dbConfig.Pessoas.Find(id);
        _dbConfig.Pessoas.Remove(pessoaToBeDeleted);
        _dbConfig.SaveChanges();
    }
}
