using GalaSoft.MvvmLight;
using LEMP3.Model;

namespace LEMP3.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ToolBoxVM = new ToolBoxViewModel();
        }

        public ToolBoxViewModel ToolBoxVM { get; set; }
    }
}