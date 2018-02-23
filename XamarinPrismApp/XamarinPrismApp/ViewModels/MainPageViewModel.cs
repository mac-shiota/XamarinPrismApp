using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinPrismApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        // 名前入力Entry項目にバインドします
        private string _yourName;
        public string YourName
        {
            get { return _yourName; }
            set { SetProperty(ref _yourName, value); }
        }

        // メッセージ表示Label項目にバインドします
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        // 決定ButtonのCommandにバインドします。
        private DelegateCommand _decisionCommand;
        public DelegateCommand DecisionCommand
        {
            get
            {
                return this._decisionCommand = this._decisionCommand ??
                  new DelegateCommand(DecisionCommandExecute);
            }
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
        }

        private void DecisionCommandExecute()
        {
            this.Message = string.Format("{0}さん こんにちは", this.YourName);
        }

        //public void OnNavigatedFrom(NavigationParameters parameters)
        //{
        //}

        //public void OnNavigatedTo(NavigationParameters parameters)
        //{
        //}
    }
}
