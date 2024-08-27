using TPlayer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPlayer.ViewModels
{
    public class MainViewModel:ObservableObject
    {
        public MainViewModel()
        {
            LeftPanel=new VideoPlayerViewModel(this);
        }
        public BaseViewModel RightPanel { get; set; }
        public BaseViewModel LeftPanel { get; set; }
    }
}
