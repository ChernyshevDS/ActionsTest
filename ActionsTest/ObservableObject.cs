using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActionsTest
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T backing, T value, [CallerMemberName] string name = null)
        {
            if (EqualityComparer<T>.Default.Equals(backing, value))
                return false;
            backing = value;
            RaisePropertyChanged(name);
            return true;
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
