using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    interface IDoorOpener
    {
        void Open(IDoor door);
        void Close(IDoor door);
    }
}
