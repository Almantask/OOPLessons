using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    class Person
    {
        private readonly IDoorOpener _doorOpener;

        public Person(IDoorOpener doorOpener)
        {
            _doorOpener = doorOpener;
        }

        public void Close(IDoor door)
        {
            _doorOpener.Close(door);
        }

        public void Open(IDoor door)
        {
            _doorOpener.Open(door);
        }
    }
}
