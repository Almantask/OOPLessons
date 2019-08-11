using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Repositories
{
    public class TeachersRepository : Repository<Entities.Teacher, Models.Teacher>, ITeachersRepository
    {
        public TeachersRepository(ISchoolMemoryContext context)
        {
            Context = context.Teachers;
        }
    }
}