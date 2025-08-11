using System.Text.Json.Nodes;

namespace DZ110825
{
    public class Program
    {
        public static async Task<string> GetFilm(string nameFilm)
        {
            using var client = new HttpClient();
            var info = await client.GetStringAsync($"http://www.omdbapi.com/?apikey=e3092a11&t={nameFilm}");
            return info;
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (context) =>
            {

                context.Response.ContentType = "text/html; charset=utf-8";
                if (context.Request.Path == "/filmInfo" && context.Request.HasFormContentType)
                {
                    var form = await context.Request.ReadFormAsync();
                    var nameFilm = form["nameFilm"];

                    if(!string.IsNullOrEmpty(nameFilm))
                    {
                        var info = await GetFilm(nameFilm);
                        var infoFilm = JsonNode.Parse(info);
                        if (infoFilm["Response"].ToString() == "False") { await context.Response.SendFileAsync("html/form.html"); return;  }
                        var html = await File.ReadAllTextAsync("html/result.html");
                        html = html.Replace("{{img}}", $"\"{infoFilm["Poster"]?.ToString() ?? ""}\"");
                        html = html.Replace("{{name}}", nameFilm);
                        html = html.Replace("{{rating}}", infoFilm["imdbRating"].ToString() ?? "");
                        html = html.Replace("{{director}}", infoFilm["Director"].ToString() ?? "");
                        html = html.Replace("{{year}}", infoFilm["Year"].ToString() ?? "");
                        html = html.Replace("{{genres}}", infoFilm["Genre"].ToString() ?? "");
                        html = html.Replace("{{desc}}", infoFilm["Plot"].ToString() ?? "");

                        await context.Response.WriteAsync(html);
                    }
                }
                else
                {
                    await context.Response.SendFileAsync("html/form.html");
                }
            });
            app.Run();
        }
    }
}
