using System;

namespace Task1
{
    class Weight
    {
        public static int homeWork = 97;
        public static int project = 82;
        public static int quizzes = 60;
        public static int exams = 75;
        public static int finalExam = 80;

        public static double homeWorkWeight = .1;
        public static double projectWeight = .35;
        public static double quizzesWeight = .1;
        public static double examsWeight = .30;
        public static double finalExamWeight = .15;

        public static double weightedAvg;

        public static void Display()
        {
            Console.WriteLine("<-----------Weight average calcution----------->");
            Console.WriteLine($"Homework - {homeWork} Homework Weight - {homeWorkWeight:p0}\nProject - {project} Project Weight - {projectWeight:p0}\nQuizzes - {quizzes} Quizzes Weight - {quizzesWeight:p0}\nExam - {exams} Exam Weight - {examsWeight:p0}\nFinal Exam  - {finalExam} Final Exam Weight - {finalExamWeight:p0}\n");
            Console.WriteLine($"Weighted Average - {weightedAvg:f2}");
        }
        public static void Run()
        {
            weightedAvg = (homeWork * homeWorkWeight) +
                            (project * projectWeight) +
                            (quizzes * quizzesWeight) +
                            (exams * examsWeight) +
                            (finalExam * finalExamWeight);

            Display();
        }


    }
}