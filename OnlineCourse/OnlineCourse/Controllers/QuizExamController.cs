using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
using OnlineCourse.DapperObject;

namespace OnlineCourse.Controllers
{
    public class QuizExamController : Controller
    {
        private I_QUIZ_Quiz db = new QUIZ_QuizDA();
        private I_EXM_ExamRulesRegulation dbRules = new EXM_ExamRulesRegulationDA();
        // GET: QuiZExam
        public ActionResult Index(int? id)
        {
            Session["CourseID"] = id;
            var rules = dbRules.ExamRulesRegulations();
            //var courseQuestion = db.CourseQuizQuestion(id);
            return View(rules);
        }
        
        public ActionResult MyExam()
        {
            int id = (int)Session["CourseID"];
            var questions = db.CourseQuizQuestion(id);
            //var questions = db.Questions();
            List<QUIZ_Quiz> randomizedQuestions = RandomizedQuestionList(questions);
            int numberOfQuestionsToAsk = 10;
            List<QUIZ_Quiz> questionToAsk = randomizedQuestions.Take(numberOfQuestionsToAsk).ToList();

            return View(questionToAsk);
        }

        public static List<QUIZ_Quiz> RandomizedQuestionList(IList<QUIZ_Quiz> originalList)
        {
            List<QUIZ_Quiz> randomList = new List<QUIZ_Quiz>();
            Random random = new Random();
            QUIZ_Quiz value = default(QUIZ_Quiz);

            //now loop through all the values in the list
            while(originalList.Count()>0)
            {
                //pick a random number from the original  list
                var nextIndex = random.Next(0,originalList.Count());
                value = originalList[nextIndex];   //get the value from the random Index
                randomList.Add(value);    //add item to the new randomized list
                originalList.RemoveAt(nextIndex);   //removes values from the original list to prevent duplicate values
            }
            //return the randomized list
            return randomList;
        }
    }
}