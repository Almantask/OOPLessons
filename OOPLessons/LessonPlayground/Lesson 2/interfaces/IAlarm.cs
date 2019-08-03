using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public interface IAlarm
    {
        event EventHandler<AlarmFiredEventArgs> AlarmFired;
        void Alert(string message);
        void Toggle();

    }
}
