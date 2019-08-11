using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Repository.InMemory.Repositories
{
    public class LessonClassesRepository: Repository<Entities.LessonClass, Models.LessonClass>, ILessonClassesRepository
    {
        public LessonClassesRepository(ISchoolMemoryContext context)
        {
            Context = context.Lessons;
        }
    }
}
