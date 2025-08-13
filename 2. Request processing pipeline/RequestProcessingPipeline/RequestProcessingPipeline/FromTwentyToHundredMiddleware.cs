namespace RequestProcessingPipeline
{
    public class FromTwentyToHundredMiddleware
    {
        private readonly RequestDelegate _next;

        public FromTwentyToHundredMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string? token = context.Request.Query["number"]; // Получим число из контекста запроса
            try
            {
                int number = Convert.ToInt32(token);
                number = Math.Abs(number);
                if (number < 20)
                {
                    await _next.Invoke(context); //Контекст запроса передаем следующему компоненту
                }
                else
                {
                    string[] Tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                    if (number % 10 == 0 && context.Items["isT"] == null)
                    {
                        // Выдаем окончательный ответ клиенту
                        await context.Response.WriteAsync("Your number is " + Tens[number / 10 - 2]); 
                    }
                    else if(number % 10 == 0 && context.Items["isT"] != null)
                    {
                        context.Items["number"] = Tens[number / 10 - 2];
                    }
                    else
                    {
                        await _next.Invoke(context); // Контекст запроса передаем следующему компоненту
                        string? result = string.Empty;
                        result = context.Items["number"] as string; // получим число от компонента FromOneToTenMiddleware
                        // Выдаем окончательный ответ клиенту
                        var num = Tens[number / 10 - 2] + " " + result;

                        if (context.Items["isT"] as string != null)
                        {
                            context.Items["number"] = num;
                        }
                        else
                        {
                            await context.Response.WriteAsync("Your number is " + num);
                        }
                    }                   
                }              
            }
            catch (Exception)
            {
                // Выдаем окончательный ответ клиенту
                await context.Response.WriteAsync("Incorrect parameter");
            }
        }
    }
}
