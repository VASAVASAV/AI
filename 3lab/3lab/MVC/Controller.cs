using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Controller
    {
        MainForm MyForm;
        Model MyModel;
        public Controller(MainForm InpForm, Model InpModel)
        {
            MyForm = InpForm;
            MyModel = InpModel;
            MyModel.MyCont = this;
            MyForm.MyCont = this;
        }
    }
}
