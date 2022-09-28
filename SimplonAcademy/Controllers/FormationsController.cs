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
        public async Task<IActionResult> Index()
        {
            var viewModel = _Db.Formations.Include(v=>v.Ville).ToList();
            return Ok(viewModel);
        }
    }
}
