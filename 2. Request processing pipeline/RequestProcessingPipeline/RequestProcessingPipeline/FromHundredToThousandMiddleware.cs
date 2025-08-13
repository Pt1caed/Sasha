namespace RequestProcessingPipeline
{
    public class FromHundredToThousandMiddleware
    {
        private readonly RequestDelegate _next;

        public FromHundredToThousandMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            
            string? token = context.Request.Query["number"];
            int number = Convert.ToInt32(token);
            number = Math.Abs(number);
            string[] numbersOneNine = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
            if(number >= 100 && number < 1000)
            {
                if (context.Items["isT"] as string != "isMill")
                {
                    context.Items["isT"] = "toThou";
                }
                if (number % 100 == 0 && context.Items["isT"] as string != "isMill")
                {
                    await context.Response.WriteAsync($"Your number is {numbersOneNine[number / 100 - 1]} hundred!");
                }
                else if(number % 100 == 0 && context.Items["isT"] as string == "isMill")
                {
                    context.Items["number"] = $"{numbersOneNine[number / 100 - 1]} hundred";
                }
                else
                {
                    context.Request.QueryString = new($"?number={number % 100}");
                    await _next.Invoke(context);

                    var num = $"{numbersOneNine[number / 100 - 1]} hundred " + context.Items["number"];

                    if (context.Items["isT"] as string != "isMill")
                    {
                        await context.Response.WriteAsync($"Your number is {num}!! {context.Items["isT"] as string}");
                    }
                    else
                    {
                        context.Items["number"] = num;
                    }
                }
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
