using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.Repository.InMemory;
using LessonPlayground.Lesson_3.Repository.InMemory.Repositories;
using LessonPlayground.Lesson_3.Repository.Interfaces;
using Ninject;

namespace LessonPlayground.Lesson_3.IoC
{
    public static class NinjectConfiguration
    {
        public static ISchoolTerminal Setup()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ISchoolMemoryContext>().To<SchoolMemoryContext>();
            kernel.Bind<ITeachersRepository>().To<TeachersRepository>();
            kernel.Bind<IGradesRepository>().To<GradesRepository>();
            kernel.Bind<ILessonClassesRepository>().To<LessonClassesRepository>();
            kernel.Bind<IStudentsRepository>().To<StudentsRepository>();

            kernel.Bind<ISchoolTerminal>().To<SchoolTerminal>();

            return kernel.Get<ISchoolTerminal>();
        }
    }
}
