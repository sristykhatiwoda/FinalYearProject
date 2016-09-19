using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;


namespace OnlineCourse.DapperObject
{
    interface I_QUIZ_Quiz
    {
        List<QUIZ_Quiz> Quizs();

        QUIZ_Quiz Find(int? id);

        int Add(QUIZ_Quiz quiz);

        int Update(QUIZ_Quiz quiz);

        int Delete(int? id);

        List<QUIZ_Quiz> Questions();

        List<QUIZ_Quiz> CourseQuizQuestion(int? id);
    }
}
