using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2.interfaces
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
