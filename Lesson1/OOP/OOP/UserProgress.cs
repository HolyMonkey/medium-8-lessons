using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class UserProgress
    {
        private List<Lesson> ViewedLessons { get; set; }

        public UserProgress(List<Lesson> viewedLessons)
        {
            ViewedLessons = viewedLessons;
        }

        public bool HasViewed(Lesson lesson)
        {
            return ViewedLessons.Contains(lesson);
        }
    }

    class Lesson
    {
        public string Name;
    }

    class CourseView
    {
        public List<Lesson> Lessons;
        public UserProgress Progress;

        public CourseView(List<Lesson> lessons, UserProgress progress)
        {
            Lessons = lessons;
            Progress = progress;
        }

        public void Show()
        {
            foreach (var lesson in Lessons)
            {
                Console.WriteLine(Progress.HasViewed(lesson) ? "Просмотрен" : "Не посмотрен");
                Console.WriteLine(lesson.Name);
            }
        }
    }
}
