using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Dados;
using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;

namespace LG.Treinamento.UIWebMVC.Controllers
{
    public class EstagiariosController : Controller
    {
        private readonly IServiceEstagiario service;

        public EstagiariosController(IServiceEstagiario service)
        {
            this.service = service;
        }

        // GET: Estagiarios
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        // GET: Estagiarios/Details/5
        public IActionResult Details(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var estagiario = service.GetEstagiario(id);
            if (estagiario == null)
            {
                return NotFound();
            }

            return View(estagiario);
        }

        // GET: Estagiarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estagiarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome")] DTOEstagiario estagiario)
        {
            if (ModelState.IsValid)
            {
                service.Create(estagiario);
                return RedirectToAction(nameof(Index));
            }
            return View(estagiario);
        }

        // GET: Estagiarios/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var estagiario = service.GetEstagiario(id);
            if (estagiario == null)
            {
                return NotFound();
            }
            return View(estagiario);
        }

        // POST: Estagiarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nome")] DTOEstagiario estagiario)
        {
            if (id != estagiario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    service.Update(estagiario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTOEstagiarioExists(estagiario.Id))
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
            return View(estagiario);
        }

        // GET: Estagiarios/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == default)
            {
                return NotFound();
            }

            var estagiario = service.GetEstagiario(id);
            if (estagiario == null)
            {
                return NotFound();
            }

            return View(estagiario);
        }

        // POST: Estagiarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var estagiario = service.GetEstagiario(id);
            service.Delete(estagiario);
            return RedirectToAction(nameof(Index));
        }

        private bool DTOEstagiarioExists(int id)
        {
            return service.GetEstagiario(id) == null;
        }
    }
}
