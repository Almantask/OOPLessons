using System;
using LessonPlayground.Lesson_2.interfaces;

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

        public void ToggleLock()
        {
            throw new NotImplementedException();
        }
    }
}
