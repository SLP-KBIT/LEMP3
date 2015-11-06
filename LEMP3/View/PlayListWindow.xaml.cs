using System.Windows;

namespace LEMP3.View
{
    /// <summary>
    /// Description for PlayListWindow.
    /// </summary>
    public partial class PlayListWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the PlayListWindow class.
        /// </summary>
        public PlayListWindow()
        {
            InitializeComponent();
            MouseLeftButtonDown += (sender, e) => this.DragMove();
            this.CloseButton.Click += (sender, e) => this.Close();
        }
    }
}