using Microsoft.AspNetCore.Http.Features;
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
        public async Task<IActionResult> GetFormationsByFilter(Guid villeId)
        {
            var formations = await _Db.Formations.Include(v=>v.Ville).Include(t=>t.FormationType).Where(v => v.VilleId == villeId).Select(s=> new
            {
                Title = s.Title,
                Description = s.Description,
                Day = s.Day,
                TimeBeginning = s.TimeBeginning,
                TimeEnd = s.TimeEnd,
                Mode = s.Mode,
                Presentation = s.Presentation,
                Admission = s.Admission,
                Programme =s.Programme,
                Competences = s.Competences,
                Ville = s.Ville.Name,
                FormationType = s.FormationType.Name
            }).ToListAsync();
            return Ok(formations);
        }
        public async Task<IActionResult> GetFormations(Guid villeId)
        {
            var formations = await _Db.Formations.Include(v => v.Ville).Include(t => t.FormationType).Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Day = s.Day,
                TimeBeginning = s.TimeBeginning,
                TimeEnd = s.TimeEnd,
                Mode = s.Mode,
                Presentation = s.Presentation,
                Admission = s.Admission,
                Programme = s.Programme,
                Competences = s.Competences,
                Ville = s.Ville.Name,
                FormationType = s.FormationType.Name
            }).ToListAsync();
            return Ok(formations);
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
    }
}
