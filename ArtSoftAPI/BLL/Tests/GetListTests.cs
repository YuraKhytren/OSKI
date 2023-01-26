using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.Data.Model;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.ProxyClases.Tests;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Tests
{
    public class GetListTests : IRun
    {
        private GetListTestsReq _req;

        public async Task<Response> ExecuteAsync(Request request, LoggerService logger)
        {
            _req = request as GetListTestsReq;

            AppRepository repository = new AppRepository();
            List<Test> tests = new List<Test>();

            tests = await repository.GetTests(); 


            return new GetListTestsResp()
            {
                Tests = tests,
                ResponseCode = CodeMessage.SW_0001
            };
        }
    }
}