using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using LEMP3.Model;
using System.Windows.Input;

namespace LEMP3.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ToolBoxViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the ToolBoxViewModel class.
        /// </summary>
        public ToolBoxViewModel()
        {
            _Player = new Player();
        }

        #region public Player Player
        private Player _Player;
        public Player Player
        {
            set
            {
                if (_Player != value)
                {
                    _Player = value;
                    RaisePropertyChanged("Player");
                }
            }
            get { return _Player; }
        }
        #endregion

        #region public ICommand PlayCommand
        private ICommand _PlayCommand;
        public ICommand PlayCommand
        {
            get
            {
                if (_PlayCommand == null)
                {
                    _PlayCommand = new RelayCommand(() => Player.Play());
                }
                return _PlayCommand;
            }
        }
        #endregion

        #region public ICommand PauseCommand
        private ICommand _PauseCommand;
        public ICommand PauseCommand
        {
            get
            {
                if (_PauseCommand == null)
                {
                    _PauseCommand = new RelayCommand(() => Player.Pause());
                }
                return _PauseCommand;
            }
        }
        #endregion

        #region public ICommand ChangeVolumeCommand
        private ICommand _ChangeVolumeCommand;
        public ICommand ChangeVolumeCommand
        {
            get
            {
                if (ChangeVolumeCommand == null)
                {
                    _ChangeVolumeCommand = new RelayCommand(() => Player.ChangeVolume());
                }
                return _ChangeVolumeCommand;
            }
        }
        #endregion
    }
}