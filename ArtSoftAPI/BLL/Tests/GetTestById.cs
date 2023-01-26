using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data.Model;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases.Tests;
using ArtSoftAPI.Service.LoggerService;
using ArtSoftAPI.ProxyClases;

namespace ArtSoftAPI.BLL.Tests
{
    public class GetTestById : IRun
    {
        private GetTestByIdReq _req;

        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetTestByIdReq;

            AppRepository repository = new AppRepository();
            Test test = new Test();

            test = await repository.GetTestById(_req.TestId);

            if (test == null)
            {
                return new GetTestByIdResp()
                {
                    Test = test,
                    ResponseCode = CodeMessage.SW_0004
                };
            }
            return new GetTestByIdResp()
            {
                Test = test,
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}