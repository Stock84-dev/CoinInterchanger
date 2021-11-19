using CoinInterchanger.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoinInterchanger.WPFViewModels
{
    public class HeaderViewModel : BaseViewModel
    {
        private WindowViewModel _windowViewModel;

        public HeaderViewModel(WindowViewModel windowViewModel)
        {
            _windowViewModel = windowViewModel;
            //MinimizeCommand = new RelayCommand(() => _windowViewModel.Minimize());
            //ChangeWindowStateCommand = new RelayCommand(() => _windowViewModel.ChangeWindowState());
            //CloseCommand = new RelayCommand(() => _windowViewModel.Close());
        }

        public ICommand MinimizeCommand { get; set; }
        public ICommand ChangeWindowStateCommand { get; set; }
        public ICommand CloseCommand { get; set; }

    }
}
