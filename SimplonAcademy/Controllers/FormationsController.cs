﻿using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplonAcademy.Data;
using SimplonAcademy.Models;
using SimplonAcademy.ViewModel;

namespace SimplonAcademy.Controllers
{
    public class FormationsController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public FormationsController(ApplicationDbContext Db)
        {
            _Db = Db;
        }


        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetFormationsByFilter(Guid? villeId, Guid? formationTypeId)
        {
            var formations = await _Db.Formations.Include(v=>v.Ville).Include(t=>t.FormationType).Where(v => v.VilleId == villeId || v.FormationTypeId == formationTypeId).Select(s=> new
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                DayStart = s.DayStart.ToString("d MMMM yyyy\t"),
                DayEnd = s.DayEnd.ToString("d MMMM yyyy\t"),
                TimeBeginning = s.TimeBeginning.ToString("hh:mm"),
                TimeEnd = s.TimeEnd.ToString("hh:mm"),
                Mode = s.Mode,
                Presentation = s.Presentation,
                Certification = s.Certification,
                Competences = s.Competences,
                Ville = s.Ville.Name,
                FormationType = s.FormationType.Name
            }).ToListAsync();
            return Ok(formations);
        }
        public async Task<IActionResult> GetFormations(Guid? villeId)
        {
            var formations = await _Db.Formations.Include(v => v.Ville).Include(t => t.FormationType).Select(s => new
            {
                Id =s.Id,
                Title = s.Title,
                Description = s.Description,
                DayStart = s.DayStart.ToString("d MMMM yyyy\t"),
                DayEnd = s.DayEnd.ToString("d MMMM yyyy\t"),
                TimeBeginning = s.TimeBeginning.ToString("hh:mm"),
                TimeEnd = s.TimeEnd.ToString("hh:mm"),
                Mode = s.Mode,
                Ville = s.Ville.Name,
                FormationType = s.FormationType.Name
            }).ToListAsync();
            return Ok(formations);
        }

        public async Task<IActionResult> FormationDetails(Guid? id)
        {
            if (id == null || _Db.Formations == null)
            {
                return NotFound();
            }

            var formationDetails = await _Db.Formations.Include(v => v.Ville).Include(t => t.FormationType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formationDetails == null)
            {
                return NotFound();
            }

            return View(formationDetails);
        }

        public async Task<IActionResult> GetFormationTypes()
        {
            var types = await _Db.FormationTypes.Include(f=>f.Formations).ToListAsync();
            return Ok(types);
        }

        public async Task<IActionResult> GetVilles()
        {
            var villes = await _Db.Villes.Include(f => f.Formations).ToListAsync();
            return Ok(villes);
        }

        [HttpPost]
        public async Task<IActionResult> Inscription(InscriptionForm inscr)
        {
            var inscription = new InscriptionForm
            {
                Id = Guid.NewGuid(),
                Nom = inscr.Nom,
                Prenom = inscr.Prenom,
                Email = inscr.Email,
                CompanyName = inscr.CompanyName,
                JobRole = inscr.JobRole,
                Phone = inscr.Phone,
                Region = inscr.Region,
                Ville = inscr.Ville, 
                FormationId = inscr.FormationId,
            };
            await _Db.AddAsync(inscription);
            await _Db.SaveChangesAsync();

            return RedirectToAction("FormationDetails", "formations", new { id = inscr.FormationId });
        }


        public async Task<IActionResult> GetInscriptions(Guid? id)
        {
            if (id == null || _Db.Formations == null)
            {
                return NotFound();
            }

            var formationDetails = await _Db.Formations.Include(v => v.Ville).Include(t => t.InscriptionForm)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formationDetails == null)
            {
                return NotFound();
            }

            return View(formationDetails);
        }
    }
}
