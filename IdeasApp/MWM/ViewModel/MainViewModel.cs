using IdeasApp.Core;

namespace IdeasApp.MWM.ViewModel;

public class MainViewModel : ObservableObject
{
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand DiscoveryViewCommand { get; set; }

    private object currentView;
    
    public object CurrentView
    {
        get { return currentView; }
        set
        {
            currentView = value; 
            OnPropertyChanged();
        }
    }

    public HomeViewModel homeVM { get; set; }

    public DiscoveryViewModel discoveryVM { get; set; }
    
    public MainViewModel()
    {
        homeVM = new HomeViewModel();
        discoveryVM = new DiscoveryViewModel();
        CurrentView = homeVM;

        HomeViewCommand = new RelayCommand(o =>
        {
            CurrentView = homeVM;
        });


        DiscoveryViewCommand = new RelayCommand(o =>
        {
            CurrentView = discoveryVM;
        });

    }
}