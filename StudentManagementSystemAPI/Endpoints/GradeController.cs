using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementSystemAPI.Repository.IRepository;
using StudentManagementSystemAPI.Models;

namespace StudentManagementSystemAPI.Endpoints
{
    public class GradeController : Controller
    {
        private readonly IGradeRepository _gradeRepository;

        public GradeController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Grade>> Get(int id)
        {
            var grade = await _gradeRepository.GetAsync(id);
            return Ok(grade);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Grade grade)
        {
            await _gradeRepository.CreateAsync(grade);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Grade grade)
        {
            await _gradeRepository.UpdateAsync(grade);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Grade grade)
        {
            await _gradeRepository.RemoveAsync(grade);
            return Ok();
        }
    }

}
