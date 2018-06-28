using DifferAnt.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;

namespace DifferAnt.ViewModels
{
    internal class ChangeListViewModel : ViewModelBase
    {
        #region fields
        private ChangeList _changeList;
        private ObservableCollection<ChangeViewModel> _changes;
        #endregion

        #region
        public ChangeListViewModel(ChangeList changeList)
        {
            Debug.Assert(changeList != null);

            _changeList = changeList;

            _changes = new ObservableCollection<ChangeViewModel>();
            foreach (Change change in _changeList)
                _changes.Add(new ChangeViewModel(change));
            _changes.CollectionChanged += Changes_CollectionChanged;
        }
        #endregion

        #region properties
        public IList<ChangeViewModel> ChangeLines
        {
            get
            {
                return _changes;
            }
        }
        #endregion

        #region event handlers
        private void Changes_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == NotifyCollectionChangedAction.Reset)
            {
                _changeList.Clear();
                _changeList.AddRange(_changes.Select(c => c.Change));
            }
            else
            {
                foreach (ChangeViewModel changeViewModel in e.OldItems)
                    _changeList.Remove(changeViewModel.Change);
                foreach (ChangeViewModel changeViewModel in e.NewItems)
                    _changeList.Add(changeViewModel.Change);
            }
        }
        #endregion
    }
}
