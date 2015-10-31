using System;
using System.Windows;
using System.Windows.Controls;

namespace LEMP3.View.Toolbox
{
    /// <summary>
    /// Description for ToolBox.
    /// </summary>
    public partial class ToolBox : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the ToolBox class.
        /// </summary>
        public ToolBox()
        {
            InitializeComponent();
            ExitButton.Click += (sender, e) => Environment.Exit(0);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}