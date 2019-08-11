using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Entities
{
    public class Person: IEntity
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public uint Id { get; set; }
    }
}
