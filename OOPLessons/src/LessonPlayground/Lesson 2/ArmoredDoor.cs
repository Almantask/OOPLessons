﻿using LessonPlayground.Lesson_2.interfaces;

namespace LessonPlayground.Lesson_2
{
    public class ArmoredDoor : Door, IDamageable
    {
        public int Armour { get; set; }

        public ArmoredDoor(int armour)
        {
            Armour = armour;
        }

        public void Damage(int damage)
        {
            Armour -= damage;
        }
    }
}
