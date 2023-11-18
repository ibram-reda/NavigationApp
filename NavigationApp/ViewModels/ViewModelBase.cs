using CommunityToolkit.Mvvm.ComponentModel;

namespace NavigationApp.ViewModels;

public class ViewModelBase : ObservableObject
{
    public virtual string Title => "Staging App";
}
