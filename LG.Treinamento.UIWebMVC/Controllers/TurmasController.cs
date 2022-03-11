using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;

namespace LG.Treinamento.UIWebMVC.Controllers
{
    public class TurmasController : Controller
    {
        private readonly IServiceTurma service;

        public TurmasController(IServiceTurma service)
        {
            this.service = service;
        }

        // GET: Turmas
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        // GET: Turmas/Details/5
        public IActionResult Details(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var turma = service.GetTurma(id);
            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        // GET: Turmas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Turmas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,Professor")] DTOTurma turma)
        {
            if (ModelState.IsValid)
            {
                service.Create(turma);
                return RedirectToAction(nameof(Index));
            }
            return View(turma);
        }

        // GET: Turmas/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var turma = service.GetTurma(id);
            if (turma == null)
            {
                return NotFound();
            }
            return View(turma);
        }

        // POST: Turmas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nome,Professor")] DTOTurma turma)
        {
            if (id != turma.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    service.Update(turma);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTOTurmaExists(turma.Id))
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
            return View(turma);
        }

        // GET: Turmas/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var turma = service
                .GetTurma(id);
            if (turma == null)
            {
                return NotFound();
            }

            return View(turma);
        }

        // POST: Turmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var turma = service.GetTurma(id);
            service.Delete(turma);
            return RedirectToAction(nameof(Index));
        }

        private bool DTOTurmaExists(int id)
        {
            return service.GetTurma(id) == null;
        }
    }
}
