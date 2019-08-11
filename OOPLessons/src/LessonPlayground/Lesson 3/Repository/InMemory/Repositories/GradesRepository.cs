using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Repositories
{
    public class GradesRepository : Repository<Entities.Grade, Models.Grade>, IGradesRepository
    {
        public GradesRepository(ISchoolMemoryContext context)
        {
            Context = context.Grades;
        }
    }
}
