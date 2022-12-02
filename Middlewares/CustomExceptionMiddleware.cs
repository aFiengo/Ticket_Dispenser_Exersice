namespace TicketDispenserExercise.Middleware;

public class GlobalExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);    
        }
        catch (System.Exception ex)
        {
            if (ex.StackTrace != null) 
            { 
                Console.WriteLine(ex.StackTrace);
            } 
            if (ex.InnerException != null && ex.InnerException.StackTrace != null)
            { 
                Console.WriteLine(ex.InnerException.StackTrace);
            } 
            throw ex;
        }        
    }
}

public static class GlobalExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
    }
}