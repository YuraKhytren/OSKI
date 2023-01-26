using ArtSoftAPI.BLL.Interface;
using ArtSoftAPI.Data;
using ArtSoftAPI.ProxyClases;
using ArtSoftAPI.Service.LoggerService;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace ArtSoftAPI.BLL
{
    public class Run
    {
        private LoggerService _logger;

        public Run(LoggerService logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Метод виконавець команди
        /// </summary>
        /// <param name="runMethod"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Response> ExecuteAsync(IRun runMethod, Request request)
        {
            Response response = new Response();
            AppRepository repository = new AppRepository();
            try
            {
                response = await runMethod.ExecuteAsync(request, _logger);
            }
            catch (TimeoutException e)
            {
                await _logger.SetError(e.Message, e.StackTrace);
                response.ResponseCode = CodeMessage.SW_0003;
            }
            catch (Exception e)
            {
                await _logger.SetError(e.Message, e.StackTrace);
                response.ResponseCode = CodeMessage.SW_0002;
            }

            return response;
        }
    }
}
