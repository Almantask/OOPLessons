using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_3.Application
{
    public class BrokenSchoolTerminal : ISchoolTerminal
    {
        public void PrintInfo()
        {
            Console.WriteLine("----Broken----");
        }
    }
}
