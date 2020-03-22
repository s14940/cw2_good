﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski, Dupka sortowanie={orderBy}";
        }


        [HttpGet("{id}")]

        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]

        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut]
        public IActionResult PutStudent(int id)
        {
            return Ok("Aktualizacja zakończona");
        }
        
        
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Usuwanie zakończone");
        }


    }
  
   
}
