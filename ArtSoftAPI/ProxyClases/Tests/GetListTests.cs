using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Tests
{
    public class GetListTestsReq : Request
    {
    }
    public class GetListTestsResp : Response
    {
        public List<Test> Tests { get; set; }
    }
}
