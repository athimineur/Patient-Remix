using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Database.MainFrame
{
    public partial class MainFrameUC : UserControl
    {
        public MainFramePresenter Presenter { get; set; }

        public MainFrameUC()
        {
            InitializeComponent();
        }

        public void SetUp()
        {
            this.Dock = DockStyle.Fill;
        }

        public void LoadDisplay(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pDisplay.Controls.Clear();
            pDisplay.Controls.Add(uc);
        }

        public void LoadFrameColor(Color c)
        {
            pBorderTop.BackColor = c;
            pBorderRight.BackColor = c;
            pBorderLeft.BackColor = c;
            pBorderBottom.BackColor = c;
        }

        public void LoadTitle(string text, Color c)
        {
            lblTitle.Text = text;
            lblTitle.ForeColor = c;
        }

        private void MainFrameUC_Load(object sender, EventArgs e)
        {
            Presenter.OnStartUp();
        }
    }
}
