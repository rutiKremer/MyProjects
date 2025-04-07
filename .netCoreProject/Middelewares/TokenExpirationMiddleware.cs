using System.Net;
using Microsoft.OpenApi.Expressions;
using PROJECT.Models;
using PROJECT.Services;
public class TokenExpirationMiddleware
{
    private readonly RequestDelegate _next;

    public TokenExpirationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public object JwtTokenValidator { get; private set; }

    public async void Invoke(HttpContext context)
    {
        var token=context.Request.Headers["Authorization"].FirstOrDefault();

        if (!string.IsNullOrEmpty(token))
        {
            if (PhoneTokenService.IsTokenExpired(token))
            {
                context.Response.Redirect("/index");
                return;
            }
            // הטוקן תקף, אז אפשר להמשיך לטעינת הדף הראשי
        }

        await _next(context);
    }
}

public static partial class MiddleExtensions
{
    public static IApplicationBuilder UseTokenExpMiddleware(this IApplicationBuilder builder )
    {
        return builder.UseMiddleware<TokenExpirationMiddleware>();
    }
}


