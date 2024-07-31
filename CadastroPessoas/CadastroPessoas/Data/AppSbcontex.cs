using CadastroPessoas.models;
using Microsoft.EntityFrameworkCore;


namespace CadastroPessoas.Data;

    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options):base(options)
    {

    }
        DbSet<Pessoa> Pessoas { get; set; } = null!;
    }

