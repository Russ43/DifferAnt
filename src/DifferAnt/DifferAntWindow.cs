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

            IList<ChangeViewModel> changeLines = new ChangeViewModel[]
            {
                new ChangeViewModel(new Change() { Kind = ChangeKind.Add, Path = "//depot/proj1/src/A.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Add, Path =  "//depot/proj1/src/B.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/One.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/Three.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/Two.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Edit, Path =  "//depot/proj1/src/WonHundred.cs"}),
                new ChangeViewModel(new Change() { Kind = ChangeKind.Remove, Path =  "//depot/proj1/src/Foo.cs"}),
            };

            ChangeListViewModel changeLineList = new ChangeListViewModel(changeLines);

            ChangeListView view = new ChangeListView();
            Content = view;
            view.DataContext = changeLineList;
        }
    }
}
