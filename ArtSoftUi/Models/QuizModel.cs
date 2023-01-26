using System.ComponentModel.DataAnnotations;

namespace ArtSoftUi.Models
{
    public class QuizModel
    {
        public string QuestionText { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }

    public class AnswerModel
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsTrue { get; set; }
    }
}
