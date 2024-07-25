using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPlayer.ViewModels;

namespace TPlayer.Infrastructure
{
    public class BaseViewModel:ObservableObject
    {
        protected readonly MainViewModel MainVM;
        public BaseViewModel(MainViewModel main)
        {
            MainVM = main;
        }
    }
}
