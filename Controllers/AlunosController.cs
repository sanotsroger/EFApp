using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFApp.Models;
using EFApp.Data;

namespace EFApp.Controllers
{
    public class AlunosController(AppDbContext context) : Controller
    {
        private AppDbContext _context { get; set; } = context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Email")] Aluno aluno)
        {
            aluno.CreatedAt = DateTime.Now;
            
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            var aluno = await _context.Alunos.FirstOrDefaultAsync(model => model.Id == id);
            return View(aluno);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,CreatedAt")] Aluno aluno)
        {
            _context.Update(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}