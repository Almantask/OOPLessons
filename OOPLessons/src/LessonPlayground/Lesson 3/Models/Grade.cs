using System;
using LessonPlayground.Lesson_3.Enums;
using LessonPlayground.Lesson_3.Repository.Interfaces;

namespace LessonPlayground.Lesson_3.Models
{
    public class Grade: IEntity
    {
        public uint Id { get; set; }
        public uint StudentId { get; set; }
        public LessonSubject Subject { get; set; }
        public DateTime DateTime { get; set; }
        public GradeEvaluation Evaluation { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Subject: {Subject}, Date:{DateTime}, Evaluation:{Evaluation}," +
                   $"{System.Environment.NewLine}Notes:{Notes}";
        }
    }
}