namespace LessonPlayground.Lesson_2.interfaces
{
    interface ISecurity
    {
        void Respond(string message);

        void Observe(IAlarm alarm);
    }
}
