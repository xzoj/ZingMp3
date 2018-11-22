﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebNhuZingMp3.Data;
using WebNhuZingMp3.Models;

namespace WebNhuZingMp3.Controllers
{
    public class SongCategoriesController : Controller
    {
        private readonly MyDbContext _context;

        public SongCategoriesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: SongCategories
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.SongCategories.Include(s => s.Category).Include(s => s.Song);
            return View(await myDbContext.ToListAsync());
        }

        // GET: SongCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songCategory = await _context.SongCategories
                .Include(s => s.Category)
                .Include(s => s.Song)
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (songCategory == null)
            {
                return NotFound();
            }

            return View(songCategory);
        }

        // GET: SongCategories/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            ViewData["SongId"] = new SelectList(_context.Song, "SongId", "SongId");
            return View();
        }

        // POST: SongCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongId,CategoryId")] SongCategory songCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(songCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", songCategory.CategoryId);
            ViewData["SongId"] = new SelectList(_context.Song, "SongId", "SongId", songCategory.SongId);
            return View(songCategory);
        }

        // GET: SongCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songCategory = await _context.SongCategories.FindAsync(id);
            if (songCategory == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", songCategory.CategoryId);
            ViewData["SongId"] = new SelectList(_context.Song, "SongId", "SongId", songCategory.SongId);
            return View(songCategory);
        }

        // POST: SongCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongId,CategoryId")] SongCategory songCategory)
        {
            if (id != songCategory.SongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongCategoryExists(songCategory.SongId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", songCategory.CategoryId);
            ViewData["SongId"] = new SelectList(_context.Song, "SongId", "SongId", songCategory.SongId);
            return View(songCategory);
        }

        // GET: SongCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songCategory = await _context.SongCategories
                .Include(s => s.Category)
                .Include(s => s.Song)
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (songCategory == null)
            {
                return NotFound();
            }

            return View(songCategory);
        }

        // POST: SongCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songCategory = await _context.SongCategories.FindAsync(id);
            _context.SongCategories.Remove(songCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongCategoryExists(int id)
        {
            return _context.SongCategories.Any(e => e.SongId == id);
        }
    }
}
