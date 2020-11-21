using CV19Main.Infrastructure.Commands;
using CV19Main.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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

        /// <summary>Статус программы///</summary>
        private string _Status = "Готов!";

        public string Status { get => _Status; set => Set(ref _Status, value); }

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecuted(object p) => true;

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);

            #endregion

        }
    }
}
