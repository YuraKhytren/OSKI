using ArtSoftAPI.BLL;

using ArtSoftAPI.BLL.Tests;
using ArtSoftAPI.ProxyClases;

using ArtSoftAPI.ProxyClases.Tests;
using ArtSoftAPI.Service.LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace ArtSoftAPI.Controllers
{
    /// <summary>
    /// Контролер для Працівників
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly LoggerService _logger;
        public TestController(LoggerService loggerService) 
        { 
            _logger = loggerService;
        }


        /// <summary>
        /// Ендпоінт для отримання Тестів
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetListTestsResp> GetListTests(GetListTestsReq request) 
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetListTests(), request);

            if (response is GetListTestsResp)
                return response as GetListTestsResp;
            else
                return new GetListTestsResp() { ResponseCode = response.ResponseCode };
        }

        /// <summary>
        /// Ендпоінт для отримання інформації про тест
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetTestByIdResp> GetTestById(GetTestByIdReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetTestById(), request);

            if (response is GetTestByIdResp)
                return response as GetTestByIdResp;
            else
                return new GetTestByIdResp() { ResponseCode = response.ResponseCode };
        }

        /// <summary>
        /// Ендпоінт для отримання запитань та відповідей для тесту
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetQuizByTestIdResp> GetQuizByTestId(GetQuizByTestIdReq request)
        {
            Run run = new Run(_logger);
            Response response = await run.ExecuteAsync(new GetQuizByTestId(), request);

            if (response is GetQuizByTestIdResp)
                return response as GetQuizByTestIdResp;
            else
                return new GetQuizByTestIdResp() { ResponseCode = response.ResponseCode };
        }
    }
}
