namespace COMP003B.Assignment2.Middleware
{
    public class RequestTrackerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestTrackerMiddleware(RequestDelegate next, ILogger<RequestTrackerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
    }
}
