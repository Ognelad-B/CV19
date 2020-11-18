using CV19Main.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19Main.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Анализ статистики Covid-19";

        /// <summary> Заголовок окна /// </summary>
        public string Title
        {
            get => _Title;
            //set =>
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnProperyChenged();
                //Set(ref _Title, value);
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnProperyChenged();
                //Set(ref _Title, value);
            set => Set(ref _Title, value);
        }
    }
}
