using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Windows.Forms;

namespace Charts
{

    public class PieChart : IObserver
    {
        /*private Panel _panel;

        public PieChart(Panel panel)
        {
            _panel = panel;
        }*/

        public void Update(object subject, object changedValue)
        {
            if (subject is StorageExplorer storageExplorer)
            {
                foreach (var fileType in fileSizes.Keys)
                {
                    var sizeInBytes = fileSizes[fileType];
                    var sizeInKB = sizeInBytes / 1024;
                    Console.WriteLine($"{fileType}: {sizeInKB} KB");
                }
            }
        }
    }

}
