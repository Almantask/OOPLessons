using System.Collections.Generic;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Entities
{
    public class Student: Person
    {
        public List<Grade> Grades { get; set; }
    }
}
