using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Patient_Database.MainFrame;
using System.Drawing;
using Patient_Database.Manager;

namespace Patient_Database.Main
{
    public class MainPresenter
    {
        MainForm view;
        MainModel model;

        public MainPresenter(MainForm view, MainModel model)
        {
            this.view = view;
            this.model = model;
            view.Presenter = this;
        }

        public void OnStartUp()
        {
            CreateMainFrame();
            LoadMainFrame();
            SetMainFrameAttributes(Color.FromArgb(77, 121, 255), "Query Manager", Color.White);

            CreateManager();
            

            
            ManagerUC managerUC = new ManagerUC();
            model.MainFramePresenter.LoadDisplay(managerUC);
        }

        public void CreateMainFrame()
        {
            MainFrameUC mainFrameUC = new MainFrameUC();
            MainFrameModel mainFrameModel = new MainFrameModel();
            MainFramePresenter mainFramePresenter = new MainFramePresenter(mainFrameUC, mainFrameModel);
            model.MainFramePresenter = mainFramePresenter;
        }

        public void SetMainFrameAttributes(Color frameColor, string title, Color titleColor)
        { 
            model.MainFramePresenter.SetFrameColor(frameColor);
            model.MainFramePresenter.SetTitle(title);
            model.MainFramePresenter.SetTitleColor(titleColor);
        }

        public void LoadMainFrame()
        {
            view.AddControl(model.MainFramePresenter.view);
        }

        public void CreateManager()
        {
            ManagerUC managerUC = new ManagerUC();
            ManagerModel managerModel = new ManagerModel();
            ManagerPresenter managerPresenter = new ManagerPresenter(managerUC, managerModel);
            model.ManagerPresenter = ManagerPresenter;
        }
    }
}
