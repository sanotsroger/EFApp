using EFApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Aluno> Alunos { get; set;}
    }    
}