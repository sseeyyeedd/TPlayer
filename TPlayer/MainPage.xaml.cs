using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TPlayer.ViewModels;
using TPlayer.Views;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TPlayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        readonly Dictionary<Type, Type> ViewModelToViewMap = new Dictionary<Type, Type>
                {
                    { typeof(VideoPlayerViewModel), typeof(VideoPlayer) },
                };
        public MainViewModel VM { get; set; }
        public MainPage(MainViewModel vm)
        {
            VM=vm;
            DataContext=vm;
            this.InitializeComponent();
            UpdateLeftPanel();
            //UpdateRightPanel();//Currently Null
        }
        public void UpdateLeftPanel()
        {
            var leftPanelViewModel = VM.LeftPanel;
            Type viewType = ViewModelToViewMap[leftPanelViewModel.GetType()];
            LeftPanelContentControl.Content = Activator.CreateInstance(viewType);
        }
        public void UpdateRightPanel()
        {
            var rightPanelViewModel = VM.RightPanel;
            Type viewType = ViewModelToViewMap[rightPanelViewModel.GetType()];
            RightPanelContentControl.Content = Activator.CreateInstance(viewType);
        }
    }
}
