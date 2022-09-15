using Bowzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowzer.Interfaces
{
    public interface IRedditService
    {
        Task<List<Child>> GetSubmissions(string subreddit);
        Task<List<Child>> GetAllPage();
    }
}
