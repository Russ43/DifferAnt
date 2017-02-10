using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DifferAnt.ViewModels;
using DifferAnt.Views;
using DifferAnt.Models;

namespace DifferAnt
{
    internal class DifferAntWindow : Window
    {
        public DifferAntWindow()
        {
            Title = "DifferAnt";

            IList<ChangeLine> changeLines = new ChangeLine[]
            {
                new ChangeLine(new Change() { Kind = ChangeKind.Add, Path = "//depot/proj1/src/A.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Add, Path =  "//depot/proj1/src/B.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/One.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/Three.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/Two.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/WonHundred.cs"}),
                new ChangeLine(new Change() { Kind = ChangeKind.Remove, Path =  "//depot/proj1/src/Foo.cs"}),
            };

            ChangeLineList changeLineList = new ChangeLineList(changeLines);

            ChangeLineListView view = new ChangeLineListView();
            Content = view;
            view.DataContext = changeLineList;
        }
    }
}
