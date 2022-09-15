using Bowzer.Interfaces;
using Bowzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bowzer.Services
{
    public class RedditService : IRedditService
    {
        HttpClient httpClient;

        string baseUrl = "https://www.reddit.com";

        public RedditService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Child>> GetSubmissions(string subreddit)
        {
            var url = $"{baseUrl}/r/{subreddit}/.json";
            var response = await httpClient.GetAsync(url);

            List<Child> submissions = new List<Child>();

            if (response.IsSuccessStatusCode)
            {
                var stuff = await response.Content.ReadFromJsonAsync<Stuff>();
                submissions = stuff.data.children;
            }
            return submissions;
        }

        public async Task<List<Child>> GetAllPage()
        {
            return await GetSubmissions("all");
        }
    }
}
