using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public interface IDoor
    {
        void Open();
        void Close();
        void ToggleLock();
    }
}
