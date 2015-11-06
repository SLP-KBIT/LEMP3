using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LEMP3.Model;
using System.Windows.Input;

namespace LEMP3.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ToolBoxVM = new ToolBoxViewModel();
            OpenPlayListCommand = new RelayCommand( () =>
                {
                    App app = App.Current as App;
                    app.ShowModalView(new PlayListViewModel());
                });
        }

        public ToolBoxViewModel ToolBoxVM { get; set; }

        public ICommand OpenPlayListCommand { get; private set; }
    }
}