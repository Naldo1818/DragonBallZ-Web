using Microsoft.AspNetCore.Mvc;
using DragonBallZ.Data;
using DragonBallZ.Models;
using Microsoft.Data.SqlClient.Server;

namespace DragonBallZ.Controllers
{
    public class DragonBallController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public DragonBallController(ApplicationDbContext dBD)
        {//This is used to pass data to the Controller 
            dbContext = dBD;
        }
        public IActionResult Index()
        {//Used to retrieve the data from the data table of our database and display it as records in a table 
            IEnumerable<ZFighters> objList = dbContext.ZFighters;
            return View(objList);
        }
        public IActionResult Create()
        {//This Action Result is used to display the Create Razor page
            return View();
        }
        public IActionResult DragonBall()
        {
            return View();
        }
        public IActionResult DragonBallZ()
        {
            return View();
        }
        public IActionResult DragonBallGT()
        {
            return View();
        }
        public IActionResult DragonBallSuper()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ZFighters zfighters) 
        {//This is used to add the new information of the form that is displayed into the database.
            if (ModelState.IsValid)
            {
            dbContext.ZFighters.Add(zfighters);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(zfighters);
        }
        public IActionResult Update(int? ID)
        {//Gets the selected information from the database we want to update and displays it.
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.ZFighters.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ZFighters zfighters)
        {//This updates the database of the current data displayed that is updated .
            if (ModelState.IsValid)
            {
            dbContext.ZFighters.Update(zfighters);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(zfighters);
        }
    }
}
