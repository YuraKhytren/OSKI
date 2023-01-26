using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.Service.LoggerService;

namespace ArtSoftAPI.BLL.Interface
{
    public interface IRun
    {
        /// <summary>
        /// Метод для виконання команди
        /// </summary>
        /// <param name="request"></param>
        /// <param name="appSettings"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        Task<Response> ExecuteAsync(Request request, LoggerService logger);
    }
}

