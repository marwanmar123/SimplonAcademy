using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SimplonAcademy.Data;
using SimplonAcademy.Data.Migrations;
using SimplonAcademy.Models;
using SimplonAcademy.ViewModel;

namespace SimplonAcademy.Controllers
{
    public class DashboardHomeController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public DashboardHomeController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public async Task<IActionResult> Index()
        {
            var homeData = new DashboardHomeViewModel()
            {
                Home = await _Db.Homes.ToListAsync(),
                Menus = await _Db.Menus.ToListAsync(),
                Teams = await _Db.Teams.ToListAsync()
            };

            return View(homeData);
        }


        #region Home

        public async Task<IActionResult> HomeControlle(Home home)
        {
            try
            {
                var controlleHome = new Home
                {
                    Id = Guid.NewGuid(),
                    
                };
                await _Db.AddAsync(controlleHome);
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return View(home);
        }


        #endregion

        #region menu

        public async Task<IActionResult> GetMenu()
        {
            var menu = await _Db.Menus.ToListAsync();
            return Ok(menu);
        }
        public async Task<IActionResult> AddMenu(Menu menu)
        {
            try
            {
                var addMenu = new Menu
                {
                    Id = Guid.NewGuid(),
                    TitleMenu = menu.TitleMenu,
                    Link = menu.Link
                };
                await _Db.AddAsync(addMenu);
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction("index", "DashboardHome");
        }

        [HttpPost]
        public async Task<IActionResult> EditMenu(Guid id, Menu menu)
        {
            var menuId = await _Db.Menus.FirstOrDefaultAsync(m => m.Id == id);
            menuId.TitleMenu = menu.TitleMenu;
            menuId.Link = menu.Link;
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "DashboardHome");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteMenu(Guid id)
        {
            var menuId = await _Db.Menus.FirstOrDefaultAsync(m => m.Id == id);
            _Db.Remove(menuId);
            await _Db.SaveChangesAsync();
            return RedirectToAction("index", "DashboardHome");

        }
        #endregion





        #region Home

        public async Task<IActionResult> GetHome()
        {
            var menu = await _Db.Homes.ToListAsync();
            return Ok(menu);
        }
        public async Task<IActionResult> AddHome(Home home)
        {
            try
            {
                var addHome = new Home
                {
                    Id = Guid.NewGuid(),
                    Logo = home.Logo,
                    TitleHeader = home.TitleHeader,
                    DescrpHeader = home.DescrpHeader,
                    VideoHeader = home.VideoHeader,
                    TitleAbout = home.TitleAbout,
                    ContentAbout = home.ContentAbout,
                    TitleOffre = home.TitleOffre,
                    DescrpOffre = home.DescrpOffre,
                    TitleTeam = home.TitleTeam,
                    DescrpTeam = home.DescrpTeam,
                    TitleContact = home.TitleContact,
                    DescrpContact = home.DescrpContact,
                    MapContact = home.MapContact,
                    EmailContact = home.EmailContact,
                    CallContact = home.CallContact,
                    LocalContact = home.LocalContact
                    //ImageHeader = home.ImageHeader,

                };

                if (Request.Form.Files.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        addHome.Logo = dataStream.ToArray();
                        //addHome.ImageHeader = dataStream.ToArray();
                    }
                }
                await _Db.AddAsync(addHome);
                await _Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction("index", "DashboardHome");
        }

        [HttpPost]
        public async Task<IActionResult> EditHome(Guid id, Home home)
        {
            var homeId = await _Db.Homes.FirstOrDefaultAsync(m => m.Id == id);
            homeId.TitleHeader = home.TitleHeader;
            homeId.DescrpHeader = home.DescrpHeader;
            homeId.VideoHeader = home.VideoHeader;
            homeId.TitleAbout = home.TitleAbout;
            homeId.ContentAbout = home.ContentAbout;
            homeId.TitleOffre = home.TitleOffre;
            homeId.DescrpOffre = home.DescrpOffre;
            homeId.TitleTeam = home.TitleTeam;
            homeId.DescrpTeam = home.DescrpTeam;
            homeId.TitleContact = home.TitleContact;
            homeId.DescrpContact = home.DescrpContact;
            homeId.MapContact = home.MapContact;
            homeId.EmailContact = home.EmailContact;
            homeId.CallContact = home.CallContact;
            homeId.LocalContact = home.LocalContact;
            await _Db.SaveChangesAsync();

            return RedirectToAction("index", "DashboardHome");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteHome(Guid id)
        {
            var homeId = await _Db.Homes.FirstOrDefaultAsync(m => m.Id == id);
            _Db.Remove(homeId);
            await _Db.SaveChangesAsync();
            return RedirectToAction("index", "DashboardHome");

        }
        #endregion
    }
}
