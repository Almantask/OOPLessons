using System;

namespace LessonPlayground.Lesson_2
{
    public class AlarmFiredEventArgs: EventArgs
    {
        public DateTime TriggeredTime { get; }
        public string Message { get; }

        public AlarmFiredEventArgs(string message)
        {
            TriggeredTime = DateTime.Now;
            Message = message;
        }
    }
}