using System.ComponentModel;

namespace DifferAnt.ViewModels
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region protected methods
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
