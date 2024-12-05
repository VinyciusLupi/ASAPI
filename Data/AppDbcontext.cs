using System.Data.Common; // Fornece suporte para manipulação de conexões e comandos de banco de dados.
using ASAPI.Models; // Importa as classes definidas no namespace ASAPI.Models
using Microsoft.EntityFrameworkCore; // Biblioteca do Entity Framework Core para interagir com bancos de dados.

public class AppDbContext : DbContext //classe base usada pelo Entity Framework Core para gerenciar conexões e operações com o banco de dados.
{
    public DbSet<Pedidos> Pedido { get; set; }
    public DbSet<Fornecedor> Fornec { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source =banco.db"); //Define o caminho para o arquivo do banco SQLite chamado banco.db
    }

} 