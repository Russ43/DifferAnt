using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DifferAnt
{
    internal class App
    {
        [STAThread]
        static private void Main()
        {
            Application application = new Application();
            application.Run(new DifferAntWindow());
        }
    }
}
