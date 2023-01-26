using ArtSoftAPI.Data;
using ArtSoftAPI.Service.LoggerService.Entities;

namespace ArtSoftAPI.Service.LoggerService
{
    public class LoggerService
    {
        private AppRepository _repository;
        private ErrorRecord errorRecord = new ErrorRecord();

        public LoggerService(AppRepository repository)
        {
            _repository = repository;
        }

        public async Task SetError(string errorMessage, string stackTrace)
        {
            string operationId = Guid.NewGuid().ToString();

            errorRecord = new ErrorRecord
            {
                OperationId = operationId,
                ErrorMessage = errorMessage,
                StackTrace = stackTrace
            };

           await _repository.SetErrorAsync(errorRecord);

        }
    }
}
