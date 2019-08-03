using LessonPlayground.Lesson_2.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LessonPlayground.Lesson_2
{
    public static class Lesson2
    {
        public static async Task Run()
        {
            var alarm = new Alarm();
            var door = new Door();
            var doorWithAlarm = new SecurityDoor(door, alarm, 5000);
            var shop = new Shop(doorWithAlarm);

            var doorOpener = new BasicOpener();
            var person = new Person(doorOpener);

            var security = new SecurityCenter();
            security.Observe(alarm);

            person.Open(doorWithAlarm);
            await Task.Delay(6000);
            person.Close(doorWithAlarm);
        }
    }
}
