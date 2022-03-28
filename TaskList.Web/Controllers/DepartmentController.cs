using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskList.DAL;
using TaskList.Domain;
using TaskList.Services.EmailService;

namespace TaskList.Web.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private TaskListDbContext _db;
        private IEmailService _emailService;
     


        public DepartmentController(ILogger<HomeController> logger, TaskListDbContext db, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
            _db = db;
        }


      

        public IActionResult Index()
        {
            return View(_db.DepartmentOsitel.AsEnumerable());
        }




        public IActionResult Create()
        {
            return View(new DepartmentOsitel());
        }

        [HttpPost]
        public IActionResult Create(DepartmentOsitel model)
        {
            if (ModelState.IsValid)
            {
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int Id)
        {
            return View(_db.DepartmentOsitel.FirstOrDefault(a => a.Id == Id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentOsitel model)
        {
            if (ModelState.IsValid)
            {
                var editModel = _db.DepartmentOsitel.Find(model.Id);
                editModel.DepartmentName = model.DepartmentName;
                editModel.IsCompleted = model.IsCompleted;
                //if (editModel.IsCompleted)
                //{
                //    await _emailService.SendEmailAsync("Kevin@test.com", "KC@test.com", "Task Was Completed", $"Task {editModel.Id} Was Completed on {DateTime.Now}");
                //}
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int Id)
        {
            return View(_db.DepartmentOsitel.FirstOrDefault(a => a.Id == Id));
        }

        [HttpPost]
        public IActionResult Delete(DepartmentOsitel model)
        {
            var deleteModel = _db.DepartmentOsitel.Find(model.Id);
            _db.Remove(deleteModel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
