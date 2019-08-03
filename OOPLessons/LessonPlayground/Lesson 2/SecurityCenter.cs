using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public class SecurityCenter : ISecurity
    {
        public void Observe(IAlarm alarm)
        {
            alarm.AlarmFired += (o, e) => Respond(e.Message);
        }

        public void Respond(string message)
        {
            Console.WriteLine($"Rushing to the place! Message: {message}");
        }


    }
}
