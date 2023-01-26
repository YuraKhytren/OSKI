using ArtSoftUi.Models;

namespace ArtSoftUi.ProxyClases
{
    public class GetTestReq
    {
    }
    public class GetTestResp
    {
        public List<Test> Tests { get; set; }
        public ResponseBody ResponseBody { get; set; }
    }


}
