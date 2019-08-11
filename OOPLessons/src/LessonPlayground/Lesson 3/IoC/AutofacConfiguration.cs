using Autofac;
using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.Repository.InMemory;
using LessonPlayground.Lesson_3.Repository.InMemory.Repositories;
using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.IoC
{
    internal static class AutofacConfiguration
    {
        public static ISchoolTerminal Setup()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TeachersRepository>().As<ITeachersRepository>();
            builder.RegisterType<SchoolMemoryContext>().As<ISchoolMemoryContext>();
            builder.RegisterType<GradesRepository>().As<IGradesRepository>(); 
            builder.RegisterType<LessonClassesRepository>().As<ILessonClassesRepository>(); 
            builder.RegisterType<StudentsRepository>().As<IStudentsRepository>(); 

            builder.RegisterType<SchoolTerminal>().As<ISchoolTerminal>(); 

             var container = builder.Build();

            return container.Resolve<ISchoolTerminal>();
        }
    }
}
