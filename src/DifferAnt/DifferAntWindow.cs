using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DifferAnt.ViewModels;
using DifferAnt.Views;
using DifferAnt.Models;
using DifferAnt.Parsers;
using System.IO;

namespace DifferAnt
{
    internal class DifferAntWindow : Window
    {
        public DifferAntWindow()
        {
            Title = "DifferAnt";

            ChangeList changeList = null;

            IParser parser = new GitParser();
            using (Stream stdin = Console.OpenStandardInput())
            {
                changeList = parser.ParseChangeList(stdin);
            }

            // for testing, add some dummy values if none were found in stdout
            if(changeList.Count == 0)
            {
                changeList.Add(new Change() { Kind = ChangeKind.Add, Path = "//depot/proj1/src/A.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Add, Path = "//depot/proj1/src/B.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Edit, Path = "//depot/proj1/src/One.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Edit, Path = "//depot/proj1/src/Three.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Edit, Path = "//depot/proj1/src/Two.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Edit, Path = "//depot/proj1/src/WonHundred.cs" });
                changeList.Add(new Change() { Kind = ChangeKind.Remove, Path = "//depot/proj1/src/Foo.cs" });
            };

            ChangeListViewModel changeLineList = new ChangeListViewModel(changeList);

            ChangeListView view = new ChangeListView();
            Content = view;
            view.DataContext = changeLineList;
        }
    }
}
