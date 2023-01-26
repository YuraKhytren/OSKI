using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data.Model;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases.Tests;
using ArtSoftAPI.Service.LoggerService;
using ArtSoftAPI.ProxyClases;

namespace ArtSoftAPI.BLL.Tests
{
    public class GetQuizByTestId : IRun
    {
        private GetQuizByTestIdReq _req;

        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetQuizByTestIdReq;

            AppRepository repository = new AppRepository();
            List<Question> questions = new List<Question>();
            List<AnswerModel> answers = new List<AnswerModel>();
            List<Quinz> getQuizByTestId = new List<Quinz>();
            Quinz quinz;

            questions = await repository.GetQuestionByTestId(_req.TestId);

            if (questions == null || questions.Count == 0)
            {
                return new GetQuizByTestIdResp()
                {
                    ResponseCode = CodeMessage.SW_0005
                };
            }

            foreach (var question in questions) 
            {
                answers = await repository.GetAnswerByQuestionId(question.Id);

                quinz = new Quinz()
                {
                    QuestionText = question.Text,
                    Answers = answers
                };
                getQuizByTestId.Add(quinz);
            }    
           
            return new GetQuizByTestIdResp()
            {
                Quinz = getQuizByTestId,
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}