using System.Windows;
using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using LEMP3.View;
using LEMP3.ViewModel;

namespace LEMP3
{
    public partial class App : Application
    {
        private Dictionary<Type, Type> ViewModels { get; set; }

        static App()
        {
            DispatcherHelper.Initialize();
        }

        public App() : base()
        {
            ViewModels = new Dictionary<Type, Type>();
            ViewModels.Add(typeof(PlayListViewModel), typeof(PlayListWindow));
        }

        public Window CreateView<T>(T viewModel)
        {
            if (ViewModels.ContainsKey(viewModel.GetType()))
            {
                Type viewType = ViewModels[viewModel.GetType()];
                Window wnd = Activator.CreateInstance(viewType) as Window;
                if (wnd != null)
                {
                    wnd.DataContext = viewModel;
                }
                return wnd;
            }
            else
            {
                return null;
            }
        }

        public bool ShowModalView<T>(T viewModel)
        {
            Window view = CreateView(viewModel);
            if (view != null)
            {
                return (view.ShowDialog() == true);
            }
            else
            {
                return false;
            }
        }

        public void ShowView<T>(T viewModel)
        {
            Window view = CreateView(viewModel);
            if (view != null)
            {
                view.Show();
            }
        }
    }
}
