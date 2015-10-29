using System.Windows;
using LEMP3.ViewModel;
using LEMP3.Model.Native;
using System;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace LEMP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region WindowSettings 依存関係プロパティ
        // public IWindowSettings WindowSettings
        // {
        //     get { return (IWindowSettings)this.GetValue(WindowSettingsProperty); }
        //     set { this.SetValue(WindowSettingsProperty, value); }
        // }
        // public static readonly DependencyProperty WindowSettingsProperty =
        //     DependencyProperty.Register("WindowSettings", typeof(IWindowSettings), typeof(MainWindow), new UIPropertyMetadata(null));
        #endregion

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MouseLeftButtonDown += (sender, e) => this.DragMove();
            Closing += (sender, e) => ViewModelLocator.Cleanup();
        }

        /* 前回の閉じたウィンドウ位置の記録．ウィンドウ設定が保存されdevelopmentでは邪魔なのでコメント
         * 
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            // 外部からウィンドウ設定の保存・復元クラスが与えられていない場合は、既定実装を使用する
            if (this.WindowSettings == null)
            {
                this.WindowSettings = new WindowSettings(this);
            }

            this.WindowSettings.Reload();

            if (this.WindowSettings.Placement.HasValue)
            {
                var hwnd = new WindowInteropHelper(this).Handle;
                var placement = this.WindowSettings.Placement.Value;
                placement.length = Marshal.SizeOf(typeof(WINDOWPLACEMENT));
                placement.flags = 0;
                placement.showCmd = (placement.showCmd == SW.SHOWMINIMIZED) ? SW.SHOWNORMAL : placement.showCmd;

                NativeMethods.SetWindowPlacement(hwnd, ref placement);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!e.Cancel)
            {
                WINDOWPLACEMENT placement;
                var hwnd = new WindowInteropHelper(this).Handle;
                NativeMethods.GetWindowPlacement(hwnd, out placement);

                this.WindowSettings.Placement = placement;
                this.WindowSettings.Save();
            }
        }
        */
    }
}