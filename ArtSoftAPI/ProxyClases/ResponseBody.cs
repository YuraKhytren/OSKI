using System.Text.Json.Serialization;

namespace ArtSoftAPI.ProxyClases
{
    public class ResponseBody
    {
        /// <summary>
        /// Код відповіді
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
        /// <summary>
        /// Тип відповіді
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Інформаційне повідомлення
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
