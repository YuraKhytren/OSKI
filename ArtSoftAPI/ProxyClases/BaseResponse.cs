using System.Text.Json.Serialization;

namespace ArtSoftAPI.ProxyClases
{
    public class BaseResponse
    {
        /// <summary>
        /// Результат обробки запиту
        /// </summary>
        [JsonPropertyName("responseBody")]
        public ResponseBody ResponseCode { get; set; }
    }
}
