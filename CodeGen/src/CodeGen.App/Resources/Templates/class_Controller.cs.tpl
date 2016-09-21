using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using {NAMESPACE_DBCONTEXT};
using {NAMESPACE_MODELS};

namespace {NAMESPACE_CONTROLLER}
{
    public class {CLASS_NAME_CONTROLLER} : Controller
    {
        private readonly {DBCONTEXT_NAME} _context;

        public {CLASS_NAME_CONTROLLER}({DBCONTEXT_NAME} context)
        {
            _context = context;    
        }

        // GET: {VIEW_NAME}
        public async Task<IActionResult> Index()
        {
            return View(await _context.{CLASS_NAME_MODEL}.ToListAsync());
        }

        // GET: {VIEW_NAME}/{DETAILS_METHODNAME}/5
        public async Task<IActionResult> {DETAILS_METHODNAME}({PRIMARYKEY_DATATYPE}? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var {INSTANCE_NAME_MODEL} = await _context.{CLASS_NAME_MODEL}.SingleOrDefaultAsync(m => m.{PRIMARYKEY_PARAMETERNAME} == id);
            if ({INSTANCE_NAME_MODEL} == null)
            {
                return NotFound();
            }

            return View({INSTANCE_NAME_MODEL});
        }

        // GET: {VIEW_NAME}/{CREATE_METHODNAME}
        public IActionResult {CREATE_METHODNAME}()
        {
            return View();
        }

        // POST: {VIEW_NAME}/{CREATE_METHODNAME}
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> {CREATE_METHODNAME}([Bind("{PROPERTIES_MODEL}")] {CLASS_NAME_MODEL} {INSTANCE_NAME_MODEL})
        {
            if (ModelState.IsValid)
            {
                _context.Add({INSTANCE_NAME_MODEL});
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View({INSTANCE_NAME_MODEL});
        }

        // GET: {VIEW_NAME}/{EDIT_METHODNAME}/5
        public async Task<IActionResult> {EDIT_METHODNAME}({PRIMARYKEY_DATATYPE}? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var {INSTANCE_NAME_MODEL} = await _context.{CLASS_NAME_MODEL}.SingleOrDefaultAsync(m => m.{PRIMARYKEY_PARAMETERNAME} == id);
            if ({INSTANCE_NAME_MODEL} == null)
            {
                return NotFound();
            }
            return View({INSTANCE_NAME_MODEL});
        }

        // POST: {VIEW_NAME}/{EDIT_METHODNAME}/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> {EDIT_METHODNAME}({PRIMARYKEY_DATATYPE} id, [Bind("{PROPERTIES_MODEL}")] {CLASS_NAME_MODEL} {INSTANCE_NAME_MODEL})
        {
            if (id != {INSTANCE_NAME_MODEL}.{PRIMARYKEY_PARAMETERNAME})
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update({INSTANCE_NAME_MODEL});
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!{CLASS_NAME_MODEL}Exists({INSTANCE_NAME_MODEL}.{PRIMARYKEY_PARAMETERNAME}))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View({INSTANCE_NAME_MODEL});
        }

        // GET: {VIEW_NAME}/{DELETE_METHODNAME}/5
        public async Task<IActionResult> {DELETE_METHODNAME}({PRIMARYKEY_DATATYPE}? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var {INSTANCE_NAME_MODEL} = await _context.{CLASS_NAME_MODEL}.SingleOrDefaultAsync(m => m.{PRIMARYKEY_PARAMETERNAME} == id);
            if ({INSTANCE_NAME_MODEL} == null)
            {
                return NotFound();
            }

            return View({INSTANCE_NAME_MODEL});
        }

        // POST: {VIEW_NAME}/{DELETE_METHODNAME}/5
        [HttpPost, ActionName("{DELETE_METHODNAME}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> {DELETE_METHODNAME}Confirmed({PRIMARYKEY_DATATYPE} id)
        {
            var {INSTANCE_NAME_MODEL} = await _context.{CLASS_NAME_MODEL}.SingleOrDefaultAsync(m => m.{PRIMARYKEY_PARAMETERNAME} == id);
            _context.{CLASS_NAME_MODEL}.Remove({INSTANCE_NAME_MODEL});
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool {CLASS_NAME_MODEL}Exists({PRIMARYKEY_DATATYPE} id)
        {
            return _context.{CLASS_NAME_MODEL}.Any(e => e.{PRIMARYKEY_PARAMETERNAME} == id);
        }
    }
}
