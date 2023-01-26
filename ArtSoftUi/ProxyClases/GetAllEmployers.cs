using ArtSoftUi.Models;

namespace ArtSoftUi.ProxyClases
{
    public class GetQuizReq
    {
      public int TestId { get; set; }
    }
    public class GetQuizResp
    {
        public List<QuizModel> Quinz { get; set; }
        public ResponseBody ResponseBody { get; set; }
    }
}
