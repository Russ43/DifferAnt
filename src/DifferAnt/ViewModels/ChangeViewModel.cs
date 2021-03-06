﻿using DifferAnt.Models;
using System.Diagnostics;

namespace DifferAnt.ViewModels
{
    internal class ChangeViewModel : ViewModelBase
    {
        #region fields
        private bool _hasBeenReviewed;
        private Change _change;
        #endregion

        #region constructors
        public ChangeViewModel(Change change)
        {
            Debug.Assert(change != null);

            _hasBeenReviewed = false;
            _change = change;
        }
        #endregion

        #region properties
        public Change Change
        {
            get
            {
                return _change;
            }
        }

        public bool HasBeenReviewed
        {
            get
            {
                return _hasBeenReviewed;
            }
            set
            {
                if(_hasBeenReviewed != value)
                {
                    _hasBeenReviewed = value;
                    RaisePropertyChangedEvent(nameof(HasBeenReviewed));
                }
            }
        }

        public ChangeKind ChangeKind
        {
            get
            {
                return _change.Kind;
            }
            set
            {
                if(_change.Kind != value)
                {
                    _change.Kind = value;
                    RaisePropertyChangedEvent(nameof(ChangeKind));
                }
            }
        }

        public string ChangePath
        {
            get
            {
                return _change.Path;
            }
            set
            {
                if(_change.Path != null)
                {
                    _change.Path = value;
                    RaisePropertyChangedEvent(nameof(ChangePath));
                }
            }
        }
        #endregion
    }
}
