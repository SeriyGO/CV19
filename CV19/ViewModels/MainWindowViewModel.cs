using System;
using System.Collections.Generic;
using System.Text;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
  internal class MainWindowViewModel:ViewModel
  {
    #region Заголовок окна
    private string _Title="Analiz staticstic of CV19";
    public string Title 
    {
      get => _Title;
      set => Set(ref _Title, value);
    }
    #endregion

  }
}
