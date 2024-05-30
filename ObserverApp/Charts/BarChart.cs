using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Windows.Forms;

namespace Charts
{
    public class BarChart : IObserver
    {
        //private Panel _panel;

        /*public BarChart(Panel panel)
        {
            _panel = panel;
        }*/

        public void Update(object subject, object changedValue)
        {
            if (subject is StorageExplorer storageExplorer)
            {
                var folderSizes = storageExplorer.GetFolderSizes();
            }
        }
    }

}
