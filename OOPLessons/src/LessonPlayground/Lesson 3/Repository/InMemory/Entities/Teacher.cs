﻿namespace LessonPlayground.Lesson_3.Repository.InMemory.Entities
{
    public class Teacher : Person
    {
        public string PhoneNumber { get; set; }
        public LessonClass LessonClass { get; set; }
        public uint LessonClassId { get; set; }
    }
}
