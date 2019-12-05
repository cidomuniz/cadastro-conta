using cadastro_conta.webapi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace cadastro_conta.webapi.Middleware
{
    [ExcludeFromCodeCoverage]
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(new { mensagem = "Erro inesperado!" }));
                    }
                });
            });
        }
    }
}
