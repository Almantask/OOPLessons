using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public class Alarm: IAlarm
    {
        public event EventHandler<AlarmFiredEventArgs> AlarmFired;

        public bool IsOn { get; private set;}
        
        public Alarm()
        {
            IsOn = true;
        }

        public void Toggle() => IsOn = !IsOn;

        public void Alert(string message)
        {
            Console.WriteLine("BEEP BEEP BEEP");
            AlarmFired?.Invoke(this, new AlarmFiredEventArgs(message));
        }
    }
}
