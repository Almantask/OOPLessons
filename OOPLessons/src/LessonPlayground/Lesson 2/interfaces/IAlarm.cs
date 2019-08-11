using System;

namespace LessonPlayground.Lesson_2.interfaces
{
    public interface IAlarm
    {
        event EventHandler<AlarmFiredEventArgs> AlarmFired;
        void Alert(string message);
        void Toggle();

    }
}
