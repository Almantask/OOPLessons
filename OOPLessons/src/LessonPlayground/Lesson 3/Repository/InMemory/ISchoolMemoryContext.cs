using System.Collections.Generic;
using LessonPlayground.Lesson_3.Repository.InMemory.Entities;

namespace LessonPlayground.Lesson_3.Repository.InMemory
{
    public interface ISchoolMemoryContext
    {
        List<Student> Students { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Grade> Grades { get; set; }
        List<LessonClass> Lessons { get; set; }
    }
}