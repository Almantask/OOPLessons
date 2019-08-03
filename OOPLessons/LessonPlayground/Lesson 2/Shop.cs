using System;
using System.Collections.Generic;
using System.Text;

namespace LessonPlayground.Lesson_2
{
    public class Shop: IShop
    {
        private IDoor _doors;
        
        public Shop(IDoor doors)
        {
            _doors = doors;
        }

        public void Open()
        {
            _doors.ToggleLock();
            Console.WriteLine("Shop opened");
        }

        public void Close()
        {
            _doors.ToggleLock();
            Console.WriteLine("Shop closed")
        }

        public void Sell()
        {
            
        }
    }
}
