using Microsoft.AspNetCore.Mvc.Formatters;

namespace RequestProcessingPipeline
{
    public class FromThousandToMillionMiddleware
    {
        private readonly RequestDelegate _next;

        public FromThousandToMillionMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            
            string? token = context.Request.Query["number"];
            int number = Convert.ToInt32(token);
            number = Math.Abs(number);
            if (number >= 1000 && number < 1000000)
            {
                context.Items["isT"] = "isMill";


                context.Request.QueryString = new($"?number={number / 1000}");
                await _next.Invoke(context);
                var count = context.Items["number"];

                if (number == 1000)
                {
                    await context.Response.WriteAsync($"Your number is one thousand");
                }
                else if (number % 1000 == 0 )
                {
                    await context.Response.WriteAsync($"Your number is {count} thousand");
                }
                else
                {
                    context.Request.QueryString = new($"?number={number % 1000}");
                    await _next.Invoke(context);
                    await context.Response.WriteAsync($"Your number is {count} thousand and {context.Items["number"]}");
                }
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
