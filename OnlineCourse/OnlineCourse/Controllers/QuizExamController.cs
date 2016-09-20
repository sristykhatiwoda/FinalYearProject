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
        private I_EXM_ExamHistory dbHistory = new EXM_ExamHistoryDA();
        private I_EXM_ExamHistoryDetail dbHistoryDetail = new EXM_ExamHistoryDetailDA();
        QUIZ_Quiz quiz = new QUIZ_Quiz();
        static TimeSpan startTime;
        static int historyId = 0;

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
            if (Session["CourseID"]!=null)
            { 
                int id = (int)Session["CourseID"];

                // var questions = db.CourseQuizQuestion(id);
                Session["Start"] = DateTime.Now;
                startTime = Convert.ToDateTime(Session["Start"]).TimeOfDay;
                List<QUIZ_Quiz> questions = db.CourseQuizQuestion(id);
                List<QUIZ_Quiz> randomizedQuestions = RandomizedQuestionList(questions);
                int numberOfQuestionsToAsk = 4;
                List<QUIZ_Quiz> questionToAsk = randomizedQuestions.Take(numberOfQuestionsToAsk).ToList();

                return View(questionToAsk);
            }
            return View();
        }
        [HttpPost]

        public ActionResult MyExam(FormCollection frm)
        {
            int count = Convert.ToInt32("hddCount");
            EXM_ExamHistory history = new EXM_ExamHistory();
            history.StudentID = (int)Session["StudentID"];
            history.ExamTakenDate = DateTime.Today;
            history.ExamStartTime = startTime;
            TimeSpan endTime = DateTime.Now.TimeOfDay;
            history.ExamCompletedTime = endTime;
            dbHistory.Add(history);
            historyId = history.ExamHistoryID;
            int score = 0;

            for(int i=0;i<=count-1;i++)
            {
                string ans = "Q" + i;
                string qusID = "quest" + i;
                EXM_ExamHistoryDetail historyDetail = new EXM_ExamHistoryDetail();
                historyDetail.ExamHistoryID = historyId;
                int questionID = Convert.ToInt32(frm[qusID].ToString());
                historyDetail.QuizID = questionID;
                if(!string.IsNullOrEmpty(frm[ans]))
                {
                    historyDetail.SubmittedAnswer = frm[ans];
                    
                    QUIZ_Quiz question = quiz.QuizQuestion.Where(a => a.QuizID == questionID && a.Answer == historyDetail.SubmittedAnswer).FirstOrDefault();
                    if (question != null)
                        score++;
                    historyDetail.Attempted = true;
                }

                else
                {
                    historyDetail.SubmittedAnswer = string.Empty;
                    historyDetail.Attempted = false;
                }
                dbHistoryDetail.Add(historyDetail);
            }
            EXM_ExamHistory updateHistory = dbHistory.Find(historyId);
            updateHistory.Score = score;

            return RedirectToAction("MyResult", historyId);
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