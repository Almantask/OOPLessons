using System;
using System.Timers;
using LessonPlayground.Lesson_2.interfaces;

namespace LessonPlayground.Lesson_2
{
    public class SecurityDoor: IDoor
    {
        private readonly IDoor _door;
        private readonly IAlarm _alarm;
        private readonly Timer _timer;

        public SecurityDoor(IDoor door, IAlarm alarm, int alarmTimeout)
        {
            _door = door;
            _alarm = alarm;
            _timer = new Timer();
            _timer.Interval = alarmTimeout;
            _timer.Elapsed += (o, e) => _alarm.Alert("Alarm!");
        }

        public void Open()
        {
            _door.Open();
            _timer.Start();
        }

        public void Close()
        {
            _door.Close();
            _timer.Stop();
        }

        public void ToggleLock()
        {
            _alarm.Toggle();
            Console.WriteLine("Doors locked");
        }
    }
}
