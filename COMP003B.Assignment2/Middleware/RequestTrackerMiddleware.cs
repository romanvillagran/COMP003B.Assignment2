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

        public async Task Invoke(HttpContext context)
        {
            //this Log the HTTP request method and path 
            _logger.LogInformation("Request: {Method} {Path}", context.Request.Method, context.Request.Path);
            await _next(context);
            //while this procces the middleware request and then logs the http status code
            _logger.LogInformation("Response: {StatusCode}", context.Response.StatusCode);
        }

    }
}
