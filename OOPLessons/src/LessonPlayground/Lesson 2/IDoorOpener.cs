using LessonPlayground.Lesson_2.interfaces;

namespace LessonPlayground.Lesson_2
{
    interface IDoorOpener
    {
        void Open(IDoor door);
        void Close(IDoor door);
    }
}
