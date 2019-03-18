using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Plan.Data;
using MVC_Plan.Models;

namespace MVC_Plan.Controllers
{
    public class DegreePlanTermRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreePlanTermRequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreePlanTermRequirements
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            ViewData["TermIDSortParm"] = sortOrder == "Term" ? "termId_desc" : "";
            ViewData["DegreePlanSortParm"] = sortOrder == "DegreePlan" ? "degreePlan_desc" : "DegreePlan";
            ViewData["RequirementSortParm"] = sortOrder == "Requirement" ? "requirement_desc" : "Requirement";
            ViewData["currentFilter"] = searchString;

            var degreePlanTermRequirement = from s in _context.DegreePlanTermRequirements.Include(d => d.DegreePlan).Include(d => d.Requirement)
                                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreePlanTermRequirement = degreePlanTermRequirement.Where(s => s.TermID == Convert.ToInt32(searchString));
            }

            switch (sortOrder)
            {
                case "termID_desc":
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderByDescending(s => s.TermID);
                    break;
                case "DegreePlan":
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderBy(s => s.DegreePlanID);
                    break;
                case "degreePlan_desc":
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderByDescending(s => s.DegreePlanID);
                    break;
                case "Requirement":
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderBy(s => s.RequirementID);
                    break;
                case "requirement_desc":
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderByDescending(s => s.RequirementID);
                    break;
                default:
                    degreePlanTermRequirement = degreePlanTermRequirement.OrderBy(s => s.TermID);
                    break;
            }

            return View(await degreePlanTermRequirement.AsNoTracking().ToListAsync());
        }


        // GET: DegreePlanTermRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements
                .FirstOrDefaultAsync(m => m.DegreePlanTermRequirementID == id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }

            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DegreePlanTermRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreePlanTermRequirementID,TermID,RequirementID")] DegreePlanTermRequirement degreePlanTermRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreePlanTermRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements.FindAsync(id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }
            return View(degreePlanTermRequirement);
        }

        // POST: DegreePlanTermRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreePlanTermRequirementID,TermID,RequirementID")] DegreePlanTermRequirement degreePlanTermRequirement)
        {
            if (id != degreePlanTermRequirement.DegreePlanTermRequirementID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreePlanTermRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreePlanTermRequirementExists(degreePlanTermRequirement.DegreePlanTermRequirementID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(degreePlanTermRequirement);
        }

        // GET: DegreePlanTermRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements
                .FirstOrDefaultAsync(m => m.DegreePlanTermRequirementID == id);
            if (degreePlanTermRequirement == null)
            {
                return NotFound();
            }

            return View(degreePlanTermRequirement);
        }

        // POST: DegreePlanTermRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreePlanTermRequirement = await _context.DegreePlanTermRequirements.FindAsync(id);
            _context.DegreePlanTermRequirements.Remove(degreePlanTermRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreePlanTermRequirementExists(int id)
        {
            return _context.DegreePlanTermRequirements.Any(e => e.DegreePlanTermRequirementID == id);
        }
    }
}
