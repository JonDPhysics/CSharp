using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProdCate.Models;

namespace ProdCate.Controllers
{
    public class ProdController : Controller
    {
        private TheContext _context;
        public ProdController(TheContext context)
        {
            _context = context;
        }
        [HttpGet("products")]
        public IActionResult NewProd()
        {
            Prod theProds = new Prod()
            {
                listOfProds = _context.Prods.ToList()
            };
            return View(theProds);
        }

        [HttpPost("itsaproduct")]
        public RedirectToActionResult CreateProd(Prod aProd)
        {
            if(ModelState.IsValid)
            {
                _context.Add(aProd);
                _context.SaveChanges();
                return RedirectToAction("NewProd");
            }
            return RedirectToAction("NewProd");
        }

        [HttpGet("products/{id}")]
        public IActionResult Prod(int id)
        {
            ProdInfoView toHaveNotToHave = new ProdInfoView()
            {
                ToRender = _context.Prods
                    .Include(pro => pro.AssignedCate)
                        .ThenInclude(cat => cat.CateWithProd)
                    .FirstOrDefault(pro => pro.ProdId == id),

                ToAdd = _context.Cates
                    .Include(cat => cat.AssignedProd)
                    .Where(cat => !cat.AssignedProd.Any(pro => pro.ProdId == id))
                    .ToList()
            };

            return View(toHaveNotToHave);
        }
        [HttpPost("cate/{id}/add")]
        public IActionResult CateToProd(int id, ProdInfoView viewModel)
        {
            if (ModelState.IsValid)
            {
                Asso fromForm = viewModel.AddCate;
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("Prod", new {ProdId = id});
            }
            else
            {
                return Prod(id);
            }
        }

        [HttpGet("categories")]
        public IActionResult NewCate()
        {
            Cate theCate = new Cate()
            {
                listOfCates = _context.Cates.ToList()
            };
            return View(theCate);
        }

        [HttpPost("itsacategory")]
        public RedirectToActionResult CreateCate(Cate aCate)
        {
            if(ModelState.IsValid)
            {
                _context.Add(aCate);
                _context.SaveChanges();
                return RedirectToAction("NewCate");
            }
            return RedirectToAction("NewCate");
        }

        [HttpGet("categories/{Cateid}")]
        public IActionResult Cate(int )
        {
            return View();
        }

        [HttpPost("prod/{id}/add")]
        public RedirectToActionResult ProdToCate(int id, CateInfoView viewModel)
        {
            if (ModelState.IsValid)
            {
                Asso fromForm = viewModel.AddProd;
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("Cate", new {Cateid = id});
            }
            else
            {
                return Cate(id);
            }
        }
    }
}