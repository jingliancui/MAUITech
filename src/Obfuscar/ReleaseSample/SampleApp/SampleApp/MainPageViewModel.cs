using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp
{
    public class MainPageViewModel: ObservableObject
    {
        public MainPageViewModel()
        {
            OpenNewWinCommand = new RelayCommand(OpenNewWin);
            OpenNewWinBtnText = "Open a New Window";
        }

        public ICommand OpenNewWinCommand { get; set; }
        public void OpenNewWin()
        {
            var secondPage = new Window(new SecondPage());
            Application.Current.OpenWindow(secondPage);
        }

        private string openNewWinBtnText;
        public string OpenNewWinBtnText
        {
            get => openNewWinBtnText;
            set => SetProperty(ref openNewWinBtnText, value);
        }
    }
}
