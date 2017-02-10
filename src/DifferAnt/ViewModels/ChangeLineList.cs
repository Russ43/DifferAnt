using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferAnt.ViewModels
{
    internal class ChangeLineList : ViewModelBase
    {
        #region fields
        private IList<ChangeLine> _changeLines;
        #endregion

        #region
        public ChangeLineList(IList<ChangeLine> changeLines)
        {
            Debug.Assert(changeLines != null);

            _changeLines = changeLines;
        }
        #endregion

        #region properties
        public IList<ChangeLine> ChangeLines
        {
            get
            {
                return _changeLines;
            }
        }
        #endregion
    }
}
