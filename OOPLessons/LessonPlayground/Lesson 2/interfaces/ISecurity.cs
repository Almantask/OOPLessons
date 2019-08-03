using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    interface ISecurity
    {
        void Respond(string message);

        void Observe(IAlarm alarm);
    }
}
