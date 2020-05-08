using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MVPClassDiagram
{
    public class Presenter
    {
        private Model model = null;
        private MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent);
        }
    
        public void mainWindow_myEvent(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
