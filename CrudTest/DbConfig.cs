using Microsoft.EntityFrameworkCore;
using CrudTest.Models;

public class DbConfig : DbContext {
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=pessoas.db");
}
