using Laba3.WpfApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;

namespace Laba3.WpfApp.ViewModels
{
    public class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double _number1;
        public double Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged(nameof(Number4));
            }
        }

        private double _number2;
        public double Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged(nameof(Number4));
            }
        }

        private double _number3;
        public double Number3
        {
            get { return _number3; }
            set
            {
                _number3 = value;
                OnPropertyChanged(nameof(Number4));
            }
        }





        public double Number4  => Model.GetSquare(Number1, Number2, Number3);


    }

    
}

