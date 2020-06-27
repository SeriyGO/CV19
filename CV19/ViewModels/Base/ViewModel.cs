using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CV19.ViewModels.Base
{
  internal abstract class ViewModel:INotifyPropertyChanged,IDisposable
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string PropertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
    protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
    {
      if (Equals(field, value)) return false;
      field = value;
      OnPropertyChanged(PropertyName);
      return true;
    }
    public void Dispose()
    {
      Dispose(true);
      //Освобождение управляемых ресурсов
    }
    public void Dispose(bool Disposing)
    {
      if (!Disposing || _Disposed)
        _Disposed = true;
      //Освобождение управляемых ресурсов
    }
    private bool _Disposed;
  }
}
