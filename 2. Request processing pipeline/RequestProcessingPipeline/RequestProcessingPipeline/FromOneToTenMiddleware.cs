﻿namespace RequestProcessingPipeline
{
    public class FromOneToTenMiddleware
    {
        private readonly RequestDelegate _next;

        public FromOneToTenMiddleware(RequestDelegate next)
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
                if (number == 10 && context.Items["isT"] == null)
                {
                    // Выдаем окончательный ответ клиенту
                    await context.Response.WriteAsync("Your number is ten");
                }
                else if (number == 10 && context.Items["isT"] != null)
                {
                    context.Items["number"] = "ten";
                }
                else
                {
                    string[] Ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                    // Любые числа больше 20, но не кратные 10
                    if (number > 20 || context.Items["isT"] != null)
                        // Записываем в сессионную переменную number результат для компонента FromTwentyToHundredMiddleware
                        context.Items["number"] = Ones[number % 10 - 1];
                    else
                        // Выдаем окончательный ответ клиенту
                        await context.Response.WriteAsync("Your number is " + Ones[number - 1]); // от 1 до 9
                }            
            }
            catch(Exception)
            {
                // Выдаем окончательный ответ клиенту
                await context.Response.WriteAsync("Incorrect parameter");
            }
        }
    }
}
