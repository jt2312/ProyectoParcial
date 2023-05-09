using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcUsuario.Data;
using Parcial1.Models;
using Parcial1.ViewModels;

namespace Parcial1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly MvcUsuarioContext _context;

        public UsuarioController(MvcUsuarioContext context)
        {
            _context = context;
        }

        // GET: Usuario

            public async Task<IActionResult> Index(string NameFilter)
            {
             var query = from Usuario in _context.Usuario select Usuario;

             if (!string.IsNullOrEmpty(NameFilter))
             {
                query = query.Where(x => x.Nombre.ToLower().Contains(NameFilter.ToLower())||
                x.Apellido.ToLower().Contains(NameFilter.ToLower())||
                x.nacionalidad.ToLower().Contains(NameFilter.ToLower())
                );
             }

             var model = new UsuarioViewModels();
             model.Usuarios= await query.ToListAsync();


              return _context.Usuario != null ? 
                          View(model) :
                          Problem("Entity set 'MvcUsuarioContext.Usuario'  is null.");
            }
            // public async Task<IActionResult> Index(string ApellidoFilter)
            // {
            //  var query = from Usuario in _context.Usuario select Usuario;

            //  if (!string.IsNullOrEmpty(ApellidoFilter))
            //  {
            //      query = query.Where(x => x.Apellido.Contains(ApellidoFilter));
            //  }

            //  var model = new UsuarioViewModel();
            //  model.Usuarios = await query.ToListAsync();


            //   return _context.Usuario != null ? 
            //               View(model) :
            //               Problem("Entity set 'MvcUsuarioContext.Usuario'  is null.");
            // }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Usuarioo,Contraseña,Nombre,Apellido,fechanacimiento,genero,documento,nacionalidad,domicilio,telefono,terminos")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Usuarioo,Contraseña,Nombre,Apellido,fechanacimiento,genero,documento,nacionalidad,domicilio,telefono,terminos")] Usuario usuario)
        {
            if (id != usuario.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.ID))
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
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'MvcUsuarioContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return (_context.Usuario?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
