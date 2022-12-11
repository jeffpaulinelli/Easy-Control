using Microsoft.EntityFrameworkCore;
using Easy_Control.Models;

namespace Easy_Control.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
