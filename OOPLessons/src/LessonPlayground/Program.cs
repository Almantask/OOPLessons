using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.IoC;
using LessonPlayground.Lesson_3.Repository.InMemory;
using LessonPlayground.Lesson_3.Repository.InMemory.Repositories;
using StudentsRepository = LessonPlayground.Lesson_3.Repository.InMemory.Repositories.StudentsRepository;

namespace LessonPlayground
{
    public class Program
    {
        public static void Main()
        {
            // No DI
            //ISchoolTerminal app1 = new BrokenSchoolTerminal();

            // Yes DI, no IoC
            //var context = new SchoolMemoryContext();

            //ISchoolTerminal app2 = new SchoolTerminal(
            //    new StudentsRepository(context), 
            //    new TeachersRepository(context), 
            //    new GradesRepository(context), 
            //    new LessonClassesRepository(context));

            //var app = AutofacConfiguration.Setup();
            //var app = NinjectConfiguration.Setup();
            // Yes DI, with IoC
            //var app = UnityConfiguration.Setup();

            // Service Locator
            var app = ServiceLocator.Instance.Terminal;
            app.PrintInfo();
        }
    }
}
