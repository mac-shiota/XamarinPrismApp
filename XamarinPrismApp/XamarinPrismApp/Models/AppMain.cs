using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinPrismApp.Models;


namespace XamarinPrismApp.Models
{
    [Notify]
    public class AppMain : INotifyPropertyChanged
    {
        /// <summary>
        /// Singleton
        /// </summary>
        public static AppMain Current = new AppMain();


        public string MainTitleLabel
        {
            get { return mainTitleLabel; }
            set { SetProperty(ref mainTitleLabel, value, mainTitleLabelPropertyChangedEventArgs); }
        }

        public string YourName
        {
            get { return yourName; }
            set { SetProperty(ref yourName, value, yourNamePropertyChangedEventArgs); }
        }

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value, messagePropertyChangedEventArgs); }
        }

        /// <summary>
        ///     Creates an instance.
        /// </summary>
        public AppMain()
        {

        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        private string mainTitleLabel = string.Empty;
        private static readonly PropertyChangedEventArgs mainTitleLabelPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(MainTitleLabel));

        private string yourName = string.Empty;
        private static readonly PropertyChangedEventArgs yourNamePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(YourName));

        private string message = string.Empty;
        private static readonly PropertyChangedEventArgs messagePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Message));

        //private static readonly PropertyChangedEventArgs resourcesPropertyChangedEventArgs =
        //    new PropertyChangedEventArgs(nameof(Resources));

        //private string currentCulture;

        //private static readonly PropertyChangedEventArgs currentCulturePropertyChangedEventArgs =
        //    new PropertyChangedEventArgs(nameof(CurrentCulture));

        //private string currentOpenDocument = "";
        //private static readonly PropertyChangedEventArgs currentOpenDocumentPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(CurrentOpenDocument));

        //private string currentOpenMovie = "";
        //private static readonly PropertyChangedEventArgs currentOpenMoviePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(CurrentOpenMovie));

        private void SetProperty<T>(ref T field, T value, PropertyChangedEventArgs ev)
        {   if (!System.Collections.Generic.EqualityComparer<T>.Default.Equals(field, value))
            {   field = value;
                PropertyChanged?.Invoke(this, ev);
            }
        }
        
    }
}
