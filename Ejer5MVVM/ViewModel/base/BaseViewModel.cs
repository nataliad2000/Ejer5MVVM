﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.MainVIewModel
{
   public abstract class BaseViewModel:INotifyPropertyChanged
{

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseProperty([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
}
}
