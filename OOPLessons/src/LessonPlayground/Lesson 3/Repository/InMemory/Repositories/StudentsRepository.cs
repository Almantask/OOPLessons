using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Repositories
{
    public class StudentsRepository: Repository<Entities.Student, Models.Student>, IStudentsRepository
    {
        public StudentsRepository(ISchoolMemoryContext context)
        {
            Context = context.Students;
        }
    }
}
