using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models.Contexto;
using WebApplication1.Models.Entidades;

namespace WebApplication1.Controllers
{
    public class PromocionesController : Controller
    {

        private readonly Contexto _contexto;

        public PromocionesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
           
          var lista = _contexto.bec_institutos_promociones.ToList();
            CarregaTipoUsuario();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var usuario = new bec_institutos_promociones();
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Create(bec_institutos_promociones usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.bec_institutos_promociones.Add(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            CarregaTipoUsuario();
            return View(usuario);
        }
        
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var usuario = _contexto.bec_institutos_promociones.Find(Id);

            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(bec_institutos_promociones usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.bec_institutos_promociones.Update(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                CarregaTipoUsuario();
                return View(usuario);
            }
        }
        
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var usuario = _contexto.bec_institutos_promociones.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }
        
        [HttpPost]
        public IActionResult Delete(bec_institutos_promociones _usuario)
        {
            var usuario = _contexto.bec_institutos_promociones.Find(_usuario.IdPromocion);
            if (usuario != null)
            {
                _contexto.bec_institutos_promociones.Remove(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(usuario);
        }
        
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var usuario = _contexto.bec_institutos_promociones.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CarregaTipoUsuario()
        {
            var ItensTipoUsuario = new List<SelectListItem>
            {
                new SelectListItem{ Value ="1", Text ="S"},
                 new SelectListItem{ Value ="2", Text ="N"}
                  
            };

            ViewBag.TiposUsuario = ItensTipoUsuario;
        }

        
        


    }
}