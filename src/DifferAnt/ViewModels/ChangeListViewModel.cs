using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferAnt.ViewModels
{
    internal class ChangeListViewModel : ViewModelBase
    {
        #region fields
        private IList<ChangeViewModel> _changeLines;
        #endregion

        #region
        public ChangeListViewModel(IList<ChangeViewModel> changeLines)
        {
            Debug.Assert(changeLines != null);

            _changeLines = changeLines;
        }
        #endregion

        #region properties
        public IList<ChangeViewModel> ChangeLines
        {
            get
            {
                return _changeLines;
            }
        }
        #endregion
    }
}
