using CommunityToolkit.Mvvm.Input;
using TestMauiApp.Models;

namespace TestMauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}