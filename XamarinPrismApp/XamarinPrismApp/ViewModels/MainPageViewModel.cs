using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinPrismApp.Models;

namespace XamarinPrismApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly AppMain model;

        public ReactiveProperty<string> YourName { get; }

        public ReactiveProperty<string> Message { set;  get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            // MainModel をインスタンス呼び出し ＝ オンメモリ化
            model = AppMain.Current;

            YourName = new ReactiveProperty<string>(model.YourName);
            Message = new ReactiveProperty<string>(model.Message);

            Title = "Main Page";
        }






        //// 名前入力Entry項目にバインドします
        //private string _yourName;
        //public string YourName
        //{
        //    get { return _yourName; }
        //    set { SetProperty(ref _yourName, value); }
        //}

        //// メッセージ表示Label項目にバインドします
        //private string _message;
        //public string Message
        //{
        //    get { return _message; }
        //    set { SetProperty(ref _message, value); }
        //}

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


        private void DecisionCommandExecute()
        {
            this.Message.Value = string.Format("{0}さん こんにちは", this.YourName.Value);
        }

        //public void OnNavigatedFrom(NavigationParameters parameters)
        //{
        //}

        //public void OnNavigatedTo(NavigationParameters parameters)
        //{
        //}
    }
}
