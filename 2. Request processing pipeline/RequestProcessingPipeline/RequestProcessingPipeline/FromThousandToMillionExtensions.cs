namespace RequestProcessingPipeline
{
    public static class FromThousandToMillionExtensions
    {
        public static IApplicationBuilder UseFromFromThousandToMillion(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FromThousandToMillionMiddleware>();
        }
    }
}
