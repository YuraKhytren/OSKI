namespace ArtSoftAPI.Service.LoggerService.Entities
{
    public class LogRecord
    {
        public string OperationId { get; set; }
        public string OperationType { get; set; }
        public string Headers { get; set; }
        public string Method { get; set; }
        public string Body { get; set; }
        public bool IsError { get; set; }
        public string Creator { get; set; }
        public string Stack { get; set; }
    }
}
