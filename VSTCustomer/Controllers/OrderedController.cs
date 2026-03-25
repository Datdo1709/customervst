using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VSTCustomer.Models;

namespace VSTCustomer.Controllers
{
    public class OrderedController : Controller
    {
        private readonly MyDbContext _context;

        public OrderedController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Ordered
        public async Task<IActionResult>  Index()
        {
            var res = await _context.ORDERED.Take(10).ToListAsync();
            return View(res);
        }

        // GET: Odered/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oRDERED = await _context.ORDERED
                .FirstOrDefaultAsync(m => m.ID == id);
            if (oRDERED == null)
            {
                return NotFound();
            }

            return View(oRDERED);
        }

        // GET: Odered/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Odered/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EMP_ID,ORDED_DATE,CUSTOMER_ID,ORDER_CR_HR,STS_ST_CLS,STS_ST_SER,SURFACE_CD,ORD_THK,ORD_WTH,ORD_EDGE,ORD_WGT,BASE_PRICE,EFFECT_PRICE,BIDD_PRICE,CONTRACT_NO,ORD_USAGE,ORD_STAT,END_USER,QUANTITY,DELIVERY_TIME,REMARK,CREATE_AT")] ORDERED oRDERED)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oRDERED);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oRDERED);
        }

        // GET: Odered/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oRDERED = await _context.ORDERED.FindAsync(id);
            if (oRDERED == null)
            {
                return NotFound();
            }
            return View(oRDERED);
        }

        // POST: Odered/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,EMP_ID,ORDED_DATE,CUSTOMER_ID,ORDER_CR_HR,STS_ST_CLS,STS_ST_SER,SURFACE_CD,ORD_THK,ORD_WTH,ORD_EDGE,ORD_WGT,BASE_PRICE,EFFECT_PRICE,BIDD_PRICE,CONTRACT_NO,ORD_USAGE,ORD_STAT,END_USER,QUANTITY,DELIVERY_TIME,REMARK,CREATE_AT")] ORDERED oRDERED)
        {
            if (id != oRDERED.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oRDERED);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ORDEREDExists(oRDERED.ID))
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
            return View(oRDERED);
        }

        // GET: Odered/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oRDERED = await _context.ORDERED
                .FirstOrDefaultAsync(m => m.ID == id);
            if (oRDERED == null)
            {
                return NotFound();
            }

            return View(oRDERED);
        }

        // POST: Odered/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var oRDERED = await _context.ORDERED.FindAsync(id);
            if (oRDERED != null)
            {
                _context.ORDERED.Remove(oRDERED);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ORDEREDExists(string id)
        {
            return _context.ORDERED.Any(e => e.ID == id);
        }
    }
}
