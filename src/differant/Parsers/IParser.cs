using DifferAnt.Models;
using System.IO;

namespace DifferAnt.Parsers
{
    internal interface IParser
    {
        #region methods
        ChangeList ParseChangeList(Stream stream);
        #endregion
    }
}
