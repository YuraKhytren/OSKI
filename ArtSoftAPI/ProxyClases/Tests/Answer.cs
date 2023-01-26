using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Tests
{
    public class GetQuizByTestIdReq : Request
    {
        public int TestId { get; set; }
    }
    public class GetQuizByTestIdResp : Response
    {
       public List<Quinz> Quinz { get; set; }
    }

    public class Quinz 
    {
        public string QuestionText { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
