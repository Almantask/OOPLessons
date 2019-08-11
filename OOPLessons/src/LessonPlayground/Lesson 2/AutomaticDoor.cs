using System;
using LessonPlayground.Lesson_2.interfaces;

namespace LessonPlayground.Lesson_2
{
    public class AutomaticDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("Auto closed.");
        }

        public void Open()
        {
            Console.WriteLine("Auto opened.");
        }

        public void ToggleLock()
        {
            Console.WriteLine("Doors locked");
        }
    }
}
