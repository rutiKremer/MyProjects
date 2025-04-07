using System.Diagnostics;
using PROJECT.Models;
namespace PROJECT.Middlewares;

public class logMiddleware
{
    private RequestDelegate next;
    private readonly string logFilePath;


    public logMiddleware(RequestDelegate next, string logFilePath)
    {
        this.next = next;
        this.logFilePath = logFilePath;
    }

    public async void Invoke(HttpContext c)
    {
        var sw = new Stopwatch();
        sw.Start();
        await next(c);
        
        WriteLogToFile($"{c.Request.Path}.{c.Request.Method} took {sw.ElapsedMilliseconds}ms."
            + $" User: {c.User?.FindFirst("Id")?.Value ?? "unknown"}");     
    }    

    private void WriteLogToFile(string logMessage)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine(logMessage);
            }
        }
}

public static partial class MiddleExtensions
{
    public static IApplicationBuilder UselogMiddleware(this IApplicationBuilder builder, string logFilePath)
    {
        return builder.UseMiddleware<logMiddleware>(logFilePath);
    }
}