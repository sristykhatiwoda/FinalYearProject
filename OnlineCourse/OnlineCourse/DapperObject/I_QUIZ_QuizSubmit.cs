using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCourse.Models;

namespace OnlineCourse.DapperObject
{
    interface I_QUIZ_QuizSubmit
    {
        List<QUIZ_QuizSubmit> QuizSubmits();

        QUIZ_QuizSubmit Find(int? id);

        int Add(QUIZ_QuizSubmit quizSubmit);

        int Update(QUIZ_QuizSubmit quizSubmit);

        int Delete(int? id);
    }
}
