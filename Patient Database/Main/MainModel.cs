using Patient_Database.MainFrame;
using Patient_Database.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Main
{
    public class MainModel
    {
        public MainFramePresenter MainFramePresenter { get; set; }
        public ManagerPresenter ManagerPresenter { get; set; }
    }
}
