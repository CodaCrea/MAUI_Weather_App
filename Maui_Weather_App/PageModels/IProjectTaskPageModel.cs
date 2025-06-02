using CommunityToolkit.Mvvm.Input;
using Maui_Weather.Models;

namespace Maui_Weather.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}