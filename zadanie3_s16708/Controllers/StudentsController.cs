﻿using System;
 using Microsoft.AspNetCore.Mvc;
 using zadanie3_s16708.DAL;
 using zadanie3_s16708.Models;

 namespace zadanie3_s16708.Controllers
{
    
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }
        
        [HttpGet]
        public IActionResult GetStudents() {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) {
            if (id == 1) {
                return Ok("Kowalski");
            }
            else if(id == 2) {
                return Ok("Malewski");
            }
            else if(id == 3) {
                return Ok("Andrzejewski");
            }
            return NotFound("Nie znaleziono studenta");
        }
        
        [HttpPost]
        public IActionResult CreateStudent(Student student) {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut]
        public IActionResult UpdateStudent() {
           return Ok("Aktualizacja ukonczona");
        }

        [HttpDelete] public IActionResult DeleteStudent() {
            return Ok("Usuwanie ukonczone");
        }
    }
}