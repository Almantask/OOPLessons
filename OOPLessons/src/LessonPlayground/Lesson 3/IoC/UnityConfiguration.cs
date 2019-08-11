using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.Repository.InMemory;
using LessonPlayground.Lesson_3.Repository.InMemory.Repositories;
using LessonPlayground.Lesson_3.Repository.Interfaces;
using Unity;

namespace LessonPlayground.Lesson_3.IoC
{
    public static class UnityConfiguration
    {
        public static ISchoolTerminal Setup()
        {
            var container = new UnityContainer();
            container.RegisterType<ISchoolMemoryContext, SchoolMemoryContext>();
            container.RegisterType<ITeachersRepository, TeachersRepository>();
            container.RegisterType<IGradesRepository, GradesRepository>();
            container.RegisterType<ILessonClassesRepository, LessonClassesRepository>();
            container.RegisterType<IStudentsRepository, StudentsRepository>();

            container.RegisterType<ISchoolTerminal, SchoolTerminal>();

            return container.Resolve<ISchoolTerminal>();
        }
    }
}
