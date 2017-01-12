using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Database.MainFrame
{
    public class MainFramePresenter
    {
        public MainFrameUC view { get; }
        MainFrameModel model;

        public MainFramePresenter(MainFrameUC view, MainFrameModel model)
        {
            this.view = view;
            this.model = model;
            view.Presenter = this;
        }

        public void OnStartUp()
        {
            view.SetUp();
        }

        public void SetFrameColor(Color color)
        {
            model.FrameColor = color;
        }

        public void SetTitle(string title)
        {
            model.Title = title;
        }

        public void SetTitleColor(Color color)
        {
            model.TitleColor = color;
        }

        public void LoadDisplay(UserControl display)
        {
            view.LoadDisplay(display);
            view.LoadFrameColor(model.FrameColor);
            view.LoadTitle(model.Title, model.TitleColor);
        }

    }
}
