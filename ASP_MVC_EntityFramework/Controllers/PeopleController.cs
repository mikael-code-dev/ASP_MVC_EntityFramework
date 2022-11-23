﻿using ASP_MVC_EntityFramework.Data;
using ASP_MVC_EntityFramework.Models;
using ASP_MVC_EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_EntityFramework.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;
        static PeopleViewModel pvm = new();

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            pvm.listOfPeople = _context.People.Include(x => x.City).Include(y => y.City.Country).ToList();

            return View(pvm);
        }

        public IActionResult Create()
        {
            var pvm = new PersonViewModel();
            return View(pvm);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {

            PersonViewModel pwm = new PersonViewModel();
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(pwm);
            }

        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            int? numId = int.Parse(id);
            Person person = _context.People.Find(numId);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult EditPerson(string id)
        {
            int numId = int.Parse(id);
            Person person = _context.People.Find(numId);

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            int numId = person.Id;
            Person personToEdit = _context.People.Find(numId);

            if (ModelState.IsValid)
            {
                personToEdit.Name = person.Name;
                personToEdit.PhoneNumber = person.PhoneNumber;
                personToEdit.City = person.City;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(person);
            }


            return View(person);
        }

    }
}
