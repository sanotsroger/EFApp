using Microsoft.AspNetCore.Mvc;
using EFApp.Data;
using EFApp.Models;

namespace EFApp.Controllers
{
    public class TestEFController(AppDbContext db) : Controller
    {
        private AppDbContext Db { get; set; } = db;

        public IActionResult Index()
        {
            var aluno = new Aluno() {
                Name = "Antonio",
                Email = "antonio@teste.com",
                CreatedAt = DateTime.Now
            };

            // Db.Alunos.Add(aluno);
            // Db.SaveChanges();

            var alunosChange = Db.Alunos.Where(a => a.Name.Contains("José")).FirstOrDefault();
            alunosChange.Name = "José Silva";
            alunosChange.CreatedAt = DateTime.Now;
            Db.SaveChanges();

            // Db.Alunos.Remove(alunosChange);
            // Db.SaveChangesAsync();

            return Content("Ok");
        }
    }
}