using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VocaBuilder.Data;
using VocaBuilder.Models;
using VocaBuilder.Utility;

namespace VocaBuilder.Controllers
{
    public class WordsController : Controller
    {
        private readonly ApplicationDbContext context;
        public WordsController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles =AppConstant.AdminRole+ ","+AppConstant.SuperAdmin)]
        [Route("words")]
        public IActionResult WordLists()
        {
            var words = context.Word.ToList();
            return View(words);
        }

        [Authorize(Roles = AppConstant.AdminRole + "," + AppConstant.SuperAdmin)]
        [Route("word/add")]
        public IActionResult AddWord()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = AppConstant.AdminRole + "," + AppConstant.SuperAdmin)]
        [Route("word/add")]
        public async Task<IActionResult> AddWord(AddWordDto model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "One or more validations failed");
                return View();
            }

            context.Word.Add(new Core.Word { WordList = model.WordList, Definition = model.Definition, DateCreated = DateTime.Now,
                IsDeleted = false, Lesson = model.Lesson });
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(WordLists));
        }

    }
}
