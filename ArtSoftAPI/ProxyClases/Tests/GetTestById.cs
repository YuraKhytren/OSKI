using ArtSoftAPI.Data.Model;

namespace ArtSoftAPI.ProxyClases.Tests
{
    public class GetTestByIdReq : Request
    {
        public int TestId { get; set; }
    }
    public class GetTestByIdResp : Response
    {
        public Test Test { get; set; }
    }
}
