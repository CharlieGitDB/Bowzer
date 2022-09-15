using Bowzer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bowzer.Services;
using CommunityToolkit.Mvvm.Input;

namespace Bowzer.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        RedditService redditService;
        public ObservableCollection<Child> Submissions { get; set; } = new();

        public MainViewModel(RedditService redditService)
        {
            Title = "r/all";
            this.redditService = redditService;
        }

        [RelayCommand]
        async Task GetSubmissionsAsync()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
                var submissions = await redditService.GetAllPage();

                if (Submissions.Count != 0)
                {
                    Submissions.Clear();
                }

                foreach(var submission in submissions)
                {
                    Submissions.Add(submission);
                }
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Error", e.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
