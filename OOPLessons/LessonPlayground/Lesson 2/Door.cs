using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public class Door : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Door closed.");
        }

        public void Open()
        {
            Console.WriteLine("Door opened.");
        }
    }
}
