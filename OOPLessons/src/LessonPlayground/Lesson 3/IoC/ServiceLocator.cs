using System;
using System.Collections.Generic;
using System.Text;
using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.Repository.File.Repository;
using LessonPlayground.Lesson_3.Repository.InMemory;

namespace LessonPlayground.Lesson_3.IoC
{
    public class ServiceLocator
    {
        public ISchoolTerminal Terminal { get; }
        public static ServiceLocator Instance => _instance ?? (_instance = new ServiceLocator());
        private static ServiceLocator _instance;


        private ServiceLocator()
        {
            var context = new SchoolMemoryContext();

                ISchoolTerminal app = new SchoolTerminal(
                    new StudentsRepository(),
                    new TeachersRepository(),
                    new GradesRepository(),
                    new LessonClassesRepository());

                Terminal = app;
        }
    }
}
