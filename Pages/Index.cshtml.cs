using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        //    await ProcessRepositories();
        }

        // private static async Task ProcessRepositories()
        // {
        //     client.DefaultRequestHeaders.Accept.Clear();
        //     client.DefaultRequestHeaders.Accept.Add(
        //         new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        //     client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        //     var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");

        //     var msg = await stringTask;
        //     Console.Write(msg);
        // }
    }
}
