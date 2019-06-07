using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamPreparation.Entities;


namespace HowestHealthFood_FolensDylan.Controllers
{

    // Er wordt niet gekeken naar Eindresultaat, maar naar gebruik van opgenomen leerstof. Gebruik van Entities, masterLayout, Viewmodels, Views, Afwerking (Effitiëntie) en Extra punten die te verdienen zijn.
    // --------------------------------------------------------------------------------- In deelexamen    2    ,      2      ,      3    ,   5  ,     1                   ,         elk op 1  ------------------
    // Op het eindexamenn komt API daar nog bij als verbeter punt.
    // StappenPlan:
    // 1. Connectie make met database, database entities ophalen
    // 1,5. API, NA LEREN BEVESTIGEN WAAR TE DOEN.
    // 2. Opstellen Views voor al de benodigde data.
    // 3. Opstellen Viewmodels om de data efficiënt uit de entities te halen.
    // 4. Bekijk resultaat + opstellen master Layout pages.
    // 5. Overal het project bekijken en Afwerken of bijwerken waar nodig.
    // 6. Bij tijd over focussen op Extra punten.

    public class MealsController : Controller
    {
        MealsContext db;


        public MealsController()
        {
            db = new MealsContext();
        }

        // GET: Meals
        [Route("/")]
        [Route("/meals/Collection")]
        [Route("/Meals")]
        [Route("/HowestHealthyMealsCollection")]
        public IActionResult Index()
        {

            MealsModel listOfMeals = new MealsModel(db.Meals
                .OrderBy(c => c.Title).ToList());

            return View(listOfMeals);
        }

        public IActionResult Index(string word, int calories)
        {
            MealsModel listOfMeals = new MealsModel(db.Meals.Where(c => c.Title.Contains(word))
                 .OrderBy(c => c.Title).ToList());

            return View(listOfMeals);

        }
    }
}