using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using T1708E_Website.Models;

namespace T1708E_Website.Controllers
{



    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
            if (!_context.Students.Any())
            {
                _context.Students.Add(new Student()
                {
                    Name = "Trung Viet 1",
                    RollNumber = "A01"
                });
                _context.Students.Add(new Student()
                {
                    Name = "Trung Viet 2",
                    RollNumber = "A02"
                }); _context.Students.Add(new Student()
                {
                    Name = "Trung Viet 3",
                    RollNumber = "A03"
                }); _context.Students.Add(new Student()
                {
                    Name = "Trung Viet 4",
                    RollNumber = "A04"
                });
                _context.SaveChanges();
            }
        }


        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Store(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            ViewData["message"] = "Insert success";
            return Redirect("Index");
        }

        public IActionResult Edit(long id)
        {
            var existStudent = _context.Students.Find(id);
            if (existStudent == null)
            {
                return NotFound();
            }
            return View(existStudent);
        }

        public IActionResult Update(Student student)
        {
            var existStudent = _context.Students.Find(student.Id);
            if (existStudent == null)
            {
                return NotFound();
            }
            existStudent.Name = student.Name;
            existStudent.RollNumber = student.RollNumber;
            _context.Students.Update(existStudent);
            _context.SaveChanges();
            TempData["message"] = "Update success!";
            return Redirect("Index");
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            var existStudent = _context.Students.Find(id);
            if (existStudent == null)
            {
                return NotFound();
            }

            _context.Students.Remove(existStudent);
            _context.SaveChanges();

            return Json(existStudent);
        }
    }
}