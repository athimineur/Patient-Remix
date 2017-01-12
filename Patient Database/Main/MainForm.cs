using Patient_Database;
using Patient_Database.MainFrame;
using Patient_Database.Manager;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Database.Main
{
    public partial class MainForm : Form
    {
        public MainPresenter Presenter { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public void AddControl(UserControl control)
        {
            this.Controls.Add(control);
        }

        private void Main_Load(object sender, EventArgs e)
        {

            Presenter.OnStartUp();
        }


    }
}
