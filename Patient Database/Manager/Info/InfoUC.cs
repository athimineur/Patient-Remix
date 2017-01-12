using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Database.Manager.Info
{
    public partial class InfoUC : UserControl
    {
        public InfoPresenter presenter;

        public InfoUC()
        {
            presenter = new InfoPresenter(this);
            InitializeComponent();
        }

        public void AddInfoText(string info)
        {
            rtxtInfo.AppendText(info);
        }

        public void ClearInfoText()
        {
            rtxtInfo.Clear();
        }



    }
}
