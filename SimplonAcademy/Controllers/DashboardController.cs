using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            
            var formations = _Db.Formations.ToList();
            var formationTypes = _Db.FormationTypes.ToList();
            ViewBag.formationType = formationTypes;

            var villes = _Db.Villes.ToList();
            ViewBag.ville = villes;
            var DashboardViewModel = new List<DashboardViewModel>();
            foreach(Formation formation in formations)
            {
                var thisViewModel = new DashboardViewModel();
                thisViewModel.Title = formation.Title;
                thisViewModel.Description = formation.Description;
                thisViewModel.Day = formation.Day;
                thisViewModel.Time = formation.Time;
                thisViewModel.Presentation = formation.Presentation;
                thisViewModel.Admission = formation.Admission;
                thisViewModel.Programme = formation.Programme;
                thisViewModel.Competences = formation.Competences;
                thisViewModel.Mode = formation.Mode;
                thisViewModel.VilleId = formation.VilleId;
                thisViewModel.FormationTypeId = formation.FormationTypeId;
                DashboardViewModel.Add(thisViewModel);
            }

            return View(DashboardViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CreateVille(Ville ville)
        {
            var addVille = new Ville
            {
                Id = Guid.NewGuid(),
                Name = ville.Name
            };
            await _Db.AddAsync(addVille);
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "Dashboard");
        }

        [HttpPost]
        public async Task<IActionResult> CreateTypeFormation(FormationType formationType)
        {
            var addTypeFormation = new FormationType
            {
                Id = Guid.NewGuid(),
                Name = formationType.Name
            };
            await _Db.AddAsync(addTypeFormation);
            await _Db.SaveChangesAsync();

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
                Admission = formation.Admission,
                Programme = formation.Programme,
                Competences = formation.Competences,
                FormationTypeId = formation.FormationTypeId,
                VilleId = formation.VilleId,
                Time = formation.Time,
                Day = formation.Day
                
            };
            await _Db.AddAsync(addFormation);
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "Dashboard");
        }

    }
}
