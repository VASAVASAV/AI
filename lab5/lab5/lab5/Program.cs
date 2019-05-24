using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab5
{
    class StartPoint
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // ususal shit
            FormDesigner Program = new FormDesigner();
            Application.Run(Program); //creating and running our form is way to initialize all programm.
        }
    }
}
