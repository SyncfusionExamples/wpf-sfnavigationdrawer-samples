using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Commands
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool _canperformaction = true;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public ViewModel()
        {
            ClickCommand = new DelegateCommand<object>(ClickAction, CanPerformClickAction);
        }
        public bool CanPerformAction
        {
            get
            {
                return _canperformaction;
            }
            set
            {
                _canperformaction = value;
                this.ClickCommand.RaiseCanExecuteChanged();
                this.OnPropertyChanged("CanPerformAction");
            }
        }

        private bool CanPerformClickAction(object parameter)
        {
            return CanPerformAction;
        }

        public DelegateCommand<object> ClickCommand { get; set; }

        private void ClickAction(object parameter)
        {
            MessageBox.Show(parameter.ToString() + " item has been clicked");
        }

    }
}
