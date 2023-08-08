namespace CrudTest.Models;

using System.ComponentModel.DataAnnotations;

public class Pessoa {
    [Key]
    public long PessoaId { get; set; }

    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}
