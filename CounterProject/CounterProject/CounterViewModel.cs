using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PersonProject;

namespace CounterProject
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private CounterModel _displaycounter ;
        public CounterModel DisplayCounter
        {
            get => _displaycounter;
            set
            {
                _displaycounter = value;
                OnPropertyChanged(nameof(DisplayCounter));
            }


        }
        public ICommand Plus { get; }
        public ICommand Minus { get; }

        public CounterViewModel()
        {
            this.DisplayCounter = new CounterModel { Count = 0 };
            Plus = new RelayCommand(plus);
            Minus = new RelayCommand(minus);



        }
        public void plus()
        {
            DisplayCounter.Count++;
            OnPropertyChanged(nameof(DisplayCounter));
        }

        public void minus()
        {
            DisplayCounter.Count--;
            OnPropertyChanged(nameof(DisplayCounter));
        }
    }
}
