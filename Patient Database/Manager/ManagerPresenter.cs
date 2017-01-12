using Patient_Database.Collections;
using Patient_Database.Manager.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Database.Manager
{
    public class ManagerPresenter
    {
        public ManagerModel model;
        ManagerUC view;

        InfoUC info_view;

        DisplayState displayState;

        public ManagerPresenter(ManagerUC view)
        {
            model = new ManagerModel();
            info_view = new InfoUC();
            this.view = view;
            SetDisplayState(DisplayState.INFO);
        }

        public void SetDisplayState(DisplayState displayState)
        {
            if (displayState == DisplayState.INFO)
            {
                this.displayState = displayState;

            }
        }

        public void OnStartUp()
        {
            if (model.Collection == null) model.LoadDefaultCollection();
            PopulateManager();
            view.LoadDisplay(info_view);
            view.SetUpManager();
        }

        private void PopulateManager()
        {
            view.ClearManager();
            view.AddCollectionToManager(model.Collection.Name);
            int groupIterator = 0;
            foreach (Group g in model.Collection.Groups.Values)
            {
                view.AddGroupToManager(0, g.Name);
                foreach (Query q in g.Queries.Values)
                {
                    view.AddQueryToManager(groupIterator, q.Name);
                }
                groupIterator++;
            }

            view.SetManagerCurrentSelection(0, -1, -1);
            
        }

        public void SelectionChanged()
        {
            UpdateManager();
        }

        private void UpdateManager()
        {
            UpdateAddNewSelector();
            if (displayState == DisplayState.INFO) UpdateInfo();
            
        }

        private void UpdateAddNewSelector()
        {
            ManagerProperty selectedProperty = view.GetSelectedManagerProperty();
            if (selectedProperty == ManagerProperty.COLLECTION)
                view.UpdateAddNewSelectorText("Add New Group");
            else if (selectedProperty == ManagerProperty.GROUP)
                view.UpdateAddNewSelectorText("Add New Query");
            else if (selectedProperty == ManagerProperty.QUERY)
                view.UpdateAddNewSelectorText("Edit Query");
        }

        private void UpdateInfo()
        {
            ManagerProperty selectedProperty = view.GetSelectedManagerProperty();
            info_view.presenter.ClearOldInfo();
            if (selectedProperty == ManagerProperty.COLLECTION)
                info_view.presenter.UpdateInfo(model.Collection, view.GetCurrentCollection());
            
            else if (selectedProperty == ManagerProperty.GROUP)
                info_view.presenter.UpdateInfo(model.Collection, view.GetCurrentCollection(),
                        view.GetCurrentGroup());
            
            else if (selectedProperty == ManagerProperty.QUERY)
                info_view.presenter.UpdateInfo(model.Collection, view.GetCurrentCollection(),
                        view.GetCurrentGroup(), view.GetCurrentQuery());
            
        }
    }
}
