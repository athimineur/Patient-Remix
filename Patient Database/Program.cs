using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Database.Main;

namespace Patient_Database
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            MainModel mainModel = new MainModel();
            MainPresenter mainPresenter = new MainPresenter(mainForm, mainModel);
            Application.Run(mainForm);
        }
    }
}
