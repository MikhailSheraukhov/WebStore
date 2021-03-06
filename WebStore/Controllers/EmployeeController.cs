﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Position = "Начальник"
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Position = "Программист"
            }

        };        // GET: HomeController
        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult Employees()
        {

            return View(_employees);
        }
        public IActionResult EmployeeDetails(int id)
        {
            var employeeViewModel = _employees.FirstOrDefault(x => x.Id == id);
            if (employeeViewModel == null)
                return NotFound();
            return View(employeeViewModel);
        }


    }
}
