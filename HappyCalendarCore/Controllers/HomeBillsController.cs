using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyCalendarCore.Models;

namespace HappyCalendarCore.Controllers
{
    public class HomeBillsController : Controller
    {
        private readonly HappyCalendarCoreContext _context;

        public HomeBillsController(HappyCalendarCoreContext context)
        {
            _context = context;
        }

        // GET: HomeBills
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeBill.ToListAsync());
        }

        // GET: HomeBills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBill = await _context.HomeBill
                .SingleOrDefaultAsync(m => m.ID == id);
            if (homeBill == null)
            {
                return NotFound();
            }

            return View(homeBill);
        }

        // GET: HomeBills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomeBills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,BillDate,Description,Who")] HomeBill homeBill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeBill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeBill);
        }

        // GET: HomeBills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBill = await _context.HomeBill.SingleOrDefaultAsync(m => m.ID == id);
            if (homeBill == null)
            {
                return NotFound();
            }
            return View(homeBill);
        }

        // POST: HomeBills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,BillDate,Description,Who")] HomeBill homeBill)
        {
            if (id != homeBill.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeBill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeBillExists(homeBill.ID))
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
            return View(homeBill);
        }

        // GET: HomeBills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBill = await _context.HomeBill
                .SingleOrDefaultAsync(m => m.ID == id);
            if (homeBill == null)
            {
                return NotFound();
            }

            return View(homeBill);
        }

        // POST: HomeBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeBill = await _context.HomeBill.SingleOrDefaultAsync(m => m.ID == id);
            _context.HomeBill.Remove(homeBill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeBillExists(int id)
        {
            return _context.HomeBill.Any(e => e.ID == id);
        }
    }
}
