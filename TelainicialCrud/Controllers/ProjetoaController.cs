using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelainicialCrud.Areas.Identity.Data;

namespace TelainicialCrud.Controllers
{
    [Authorize]
    public class ProjetoaController : Controller
    {
        private readonly TelainicialCrudContext _context;

        public ProjetoaController(TelainicialCrudContext context)
        {
            _context = context;
        }

        // GET: Projetoa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projetoas.ToListAsync());
        }

        // GET: Projetoa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoa = await _context.Projetoas
                .FirstOrDefaultAsync(m => m.IdProjetoa == id);
            if (projetoa == null)
            {
                return NotFound();
            }

            return View(projetoa);
        }

        // GET: Projetoa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projetoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProjetoa,ProjetoaName,Descricao,valor,DataInicio,DataFinal,QuantPessoas")] Projetoa projetoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projetoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projetoa);
        }

        // GET: Projetoa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoa = await _context.Projetoas.FindAsync(id);
            if (projetoa == null)
            {
                return NotFound();
            }
            return View(projetoa);
        }

        // POST: Projetoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProjetoa,ProjetoaName,Descricao,valor,DataInicio,DataFinal,QuantPessoas")] Projetoa projetoa)
        {
            if (id != projetoa.IdProjetoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projetoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetoaExists(projetoa.IdProjetoa))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(projetoa);
        }

        // GET: Projetoa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projetoa = await _context.Projetoas
                .FirstOrDefaultAsync(m => m.IdProjetoa == id);
            if (projetoa == null)
            {
                return NotFound();
            }

            return View(projetoa);
        }

        // POST: Projetoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projetoa = await _context.Projetoas.FindAsync(id);
            if (projetoa != null)
            {
                _context.Projetoas.Remove(projetoa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetoaExists(int id)
        {
            return _context.Projetoas.Any(e => e.IdProjetoa == id);
        }
    }
}
