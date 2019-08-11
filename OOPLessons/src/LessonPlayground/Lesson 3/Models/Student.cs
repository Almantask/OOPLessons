using System.Collections.Generic;

namespace LessonPlayground.Lesson_3.Models
{
    public class Student: Person
    {
        public List<Grade> Grades { get; set; }
    }
}
