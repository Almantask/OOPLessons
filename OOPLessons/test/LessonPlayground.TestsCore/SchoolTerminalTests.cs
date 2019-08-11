using System;
using System.Collections.Generic;
using System.Text;
using LessonPlayground.Lesson_3.Application;
using LessonPlayground.Lesson_3.IoC;
using LessonPlayground.Lesson_3.Models;
using LessonPlayground.Lesson_3.Repository.InMemory;
using LessonPlayground.Lesson_3.Repository.InMemory.Repositories;
using LessonPlayground.Lesson_3.Repository.Interfaces;
using Moq;
using NUnit.Framework;
using Unity;

namespace LessonPlayground.TestsCore
{
    public class SchoolTerminalTests
    {

        [Test]
        public void Test()
        {
            

            var teacherRepoMock = new Mock<ITeachersRepository>();
            var studentsRepoMock = new Mock<IStudentsRepository>();
            var gradesRepoMock = new Mock<IGradesRepository>();
            var lessonsRepoMock = new Mock<ILessonClassesRepository>();

            var terminal = new SchoolTerminal(
                studentsRepoMock.Object, 
                teacherRepoMock.Object,
                gradesRepoMock.Object,
                lessonsRepoMock.Object);

            terminal.PrintInfo();

            teacherRepoMock.Verify(m => m.Get(), Times.Exactly(1));
            studentsRepoMock.Verify(m => m.Get(), Times.Exactly(1));
            gradesRepoMock.Verify(m => m.Get(), Times.Exactly(1));
            lessonsRepoMock.Verify(m => m.Get(), Times.Exactly(1));
        }

    }
}
