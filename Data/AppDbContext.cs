using ApiQuadrinhos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiQuadrinhos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<PaginaModel> Paginas { get; set; }
    public DbSet<QuadrinhoModel> Quadrinhos { get; set; }
    public DbSet<CapituloModel> Capitulos { get; set; }
    public DbSet<AutorModel> Autores { get; set; }
    public DbSet<UserModel> Users { get; set; }
    public DbSet<LikeModel> Likes { get; set; }
}