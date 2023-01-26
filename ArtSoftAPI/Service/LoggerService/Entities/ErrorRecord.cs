namespace ArtSoftAPI.Service.LoggerService.Entities
{
    public class ErrorRecord
    {
        public string OperationId { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
