using LessonPlayground.Lesson_2.interfaces;

namespace LessonPlayground.Lesson_2
{
    public class BasicOpener : IDoorOpener
    {
        public void Close(IDoor door)
        {
            door.Close();
        }

        public void Open(IDoor door)
        {
            door.Open();
        }
    }
}
