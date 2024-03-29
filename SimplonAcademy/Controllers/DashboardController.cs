﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using SimplonAcademy.Data;
using SimplonAcademy.Models;
using SimplonAcademy.ViewModel;
using System.Drawing;

namespace SimplonAcademy.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public DashboardController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public async Task<IActionResult> Index()
        {
            
            var formations = await _Db.Formations.ToListAsync();
            var formationTypes = await _Db.FormationTypes.ToListAsync();
            ViewBag.formationType = formationTypes;

            var villes = await _Db.Villes.ToListAsync();
            ViewBag.ville = villes;
            var DashboardViewModel = new List<DashboardViewModel>();
            foreach(Formation formation in formations)
            {
                var thisViewModel = new DashboardViewModel();
                thisViewModel.Id = formation.Id;
                thisViewModel.Title = formation.Title;
                thisViewModel.Description = formation.Description;
                thisViewModel.DayStart = formation.DayStart;
                thisViewModel.DayEnd = formation.DayEnd;
                thisViewModel.TimeBeginning = formation.TimeBeginning;
                thisViewModel.TimeEnd = formation.TimeEnd;
                thisViewModel.Presentation = formation.Presentation;
                thisViewModel.Certification = formation.Certification;
                thisViewModel.Competences = formation.Competences;
                thisViewModel.Mode = formation.Mode;
                thisViewModel.Ville = formation.Ville;
                thisViewModel.FormationType = formation.FormationType;
                DashboardViewModel.Add(thisViewModel);
            }

            return View(DashboardViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CreateVille(Ville ville)
        {
            try
            {
                var addVille = new Ville
                {
                    Id = Guid.NewGuid(),
                    Name = ville.Name
                };
                await _Db.AddAsync(addVille);
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;   
            }
            

            return RedirectToAction("index", "Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> CreateTypeFormation(FormationType formationType)
        {
            try
            {
                var addTypeFormation = new FormationType
                {
                    Id = Guid.NewGuid(),
                    Name = formationType.Name
                };
                await _Db.AddAsync(addTypeFormation);
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction("index", "Dashboard");
        }


        [HttpPost]
        public async Task<IActionResult> CreateFormation(Formation formation)
        {
            //var formationTypes = _Db.FormationTypes.ToList();
            //ViewBag.formationTypes = formationTypes;

            var addFormation = new Formation
            {
                Id = Guid.NewGuid(),
                Title = formation.Title,
                Description = formation.Description,
                Mode = formation.Mode,
                Presentation = formation.Presentation,
                Certification = formation.Certification,
                Competences = formation.Competences,
                FormationTypeId = formation.FormationTypeId,
                VilleId = formation.VilleId,
                TimeBeginning = formation.TimeBeginning,
                TimeEnd = formation.TimeEnd,
                DayStart = formation.DayStart,
                DayEnd = formation.DayEnd
                
            };
            await _Db.AddAsync(addFormation);
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "Dashboard");
        }


        [HttpPost]
        public async Task<IActionResult> EditVille(Guid id, Ville ville)
        {
            var villeId = await _Db.Villes.FirstOrDefaultAsync(m => m.Id == id);
            villeId.Name = ville.Name;
            _Db.SaveChanges();

            return RedirectToAction("index", "Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> EditTypeFormation(Guid id, FormationType formationType)
        {
            var formationTypeId = await _Db.FormationTypes.FirstOrDefaultAsync(m => m.Id == id);
            formationTypeId.Name = formationType.Name;
            _Db.SaveChanges();

            return RedirectToAction("index", "Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVille(Guid id, Ville ville)
        {
            var villeId = await _Db.Villes.Include(v=>v.Formations).ThenInclude(i => i.InscriptionForm).FirstOrDefaultAsync(m => m.Id == id);
            foreach(var f in villeId.Formations)
            {
                _Db.Remove(f);
                foreach (var i in f.InscriptionForm)
                {
                    _Db.Remove(i);
                }
            }
             _Db.Remove(villeId);
            await _Db.SaveChangesAsync();
            return RedirectToAction("index", "Dashboard");

        }

        [HttpPost]
        public async Task<IActionResult> DeleteTypeFormation(Guid id, FormationType formationType)
        {
            var formationTypeId = await _Db.FormationTypes.Include(v => v.Formations).ThenInclude(i=>i.InscriptionForm).FirstOrDefaultAsync(m => m.Id == id);
            foreach (var f in formationTypeId.Formations)
            {
                _Db.Remove(f);
                foreach (var i in f.InscriptionForm)
                {
                    _Db.Remove(i);
                }
            }
            _Db.Remove(formationTypeId);
            await _Db.SaveChangesAsync();
            return RedirectToAction("index", "Dashboard");

        }

        //public async Task<IActionResult> EditFormation(Guid id)
        //{
        //    var formationId = await _Db.Formations.FirstOrDefaultAsync(m => m.Id == id);
        //    return PartialView("_FormationEditModal", formationId);
        //}

        [HttpPost]
        public async Task<IActionResult> EditFormation(Guid id, Formation formation)
        {
            var formationId = await _Db.Formations.FirstOrDefaultAsync(m => m.Id == id);
            formationId.Title = formation.Title;
            formationId.Description = formation.Description;
            formationId.Mode = formation.Mode;
            formationId.DayStart = formation.DayStart;
            formationId.DayEnd = formation.DayEnd;
            formationId.TimeBeginning = formation.TimeBeginning;
            formationId.TimeEnd = formation.TimeEnd;
            formationId.Competences = formation.Competences;
            formationId.Certification = formation.Certification;
            formationId.VilleId = formation.VilleId;
            formationId.FormationTypeId = formation.FormationTypeId;
            formationId.Presentation = formation.Presentation;
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFormation(Guid id)
        {
            var formationId = await _Db.Formations.Include(i=>i.InscriptionForm).FirstOrDefaultAsync(m => m.Id == id);
            foreach (var i in formationId.InscriptionForm)
            {
                _Db.Remove(i);
            }
            _Db.Remove(formationId);
            await _Db.SaveChangesAsync();
            return RedirectToAction("index", "Dashboard");

        }
    }
}
