using Microsoft.AspNetCore.Mvc;
using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Repository.IRepository;

namespace StudentManagementSystemAPI.Endpoints
{
    public class LessonController : Controller
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonController(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Lesson>> Get(int id)
        {
            var lesson = await _lessonRepository.GetAsync(id);
            return Ok(lesson);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Lesson lesson)
        {
            await _lessonRepository.CreateAsync(lesson);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Lesson lesson)
        {
            await _lessonRepository.UpdateAsync(lesson);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Lesson lesson)
        {
            await _lessonRepository.RemoveAsync(lesson);
            return Ok();
        }
    }
}