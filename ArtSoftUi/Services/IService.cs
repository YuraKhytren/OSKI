using ArtSoftUi.Models;
using ArtSoftUi.ProxyClases;

namespace ArtSoftUi.Services
{
    public interface IService
    {
        Task<List<QuizModel>> GetQuiz(int testId);
        Task<List<Test>> GetTests();


    }
}
