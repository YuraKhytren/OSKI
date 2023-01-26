using ArtSoftUi.Models;
using ArtSoftUi.ProxyClases;
using Newtonsoft.Json;
using System.Text;

namespace ArtSoftUi.Services
{
    public class Service : IService
    {
        const string URL = "https://localhost:7288/Test/";

        public async Task<List<QuizModel>> GetQuiz(int testId)
        {
            GetQuizResp respList = new GetQuizResp();
            List<QuizModel> quizzes = new List<QuizModel>();
            string resp = string.Empty;
            GetQuizReq req = new GetQuizReq() 
            {
                TestId = testId,
            };

            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json");
              
                HttpResponseMessage response = await httpClient.PostAsync($"{URL}GetQuizByTestId", content);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            respList = JsonConvert.DeserializeObject<GetQuizResp>(resp);
            quizzes = respList.Quinz;

            return quizzes;
        }

        public async Task<List<Test>> GetTests()
        {
            GetTestResp respList = new GetTestResp();
            List<Test> tests = new List<Test>();
            string resp = string.Empty;
            GetTestReq req = new GetTestReq();
          

            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{URL}GetListTests", content);
                response.EnsureSuccessStatusCode();

                resp = await response.Content.ReadAsStringAsync();
            }

            respList = JsonConvert.DeserializeObject<GetTestResp>(resp);
            tests = respList.Tests;

            return tests;
        }
    }
}
