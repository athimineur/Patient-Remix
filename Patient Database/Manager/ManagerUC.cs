using Patient_Database.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Database.MainFrame;

namespace Patient_Database.Manager
{
    public partial class ManagerUC : UserControl
    {
        public ManagerPresenter presenter;

        public ManagerUC()
        {
            presenter = new ManagerPresenter(this);
            InitializeComponent();
        }

        private void ManagerUC_Load(object sender, EventArgs e)
        {
            presenter.OnStartUp();
        }

        // what happens upon selecting a node in treeview
        private void tvManager_AfterSelect(object sender, TreeViewEventArgs e)
        {
            presenter.SelectionChanged();
        }

        public void AddCollectionToManager(string collection)
        {
            tvManager.Nodes.Add(collection);
        }

        public void AddGroupToManager(int collectionLocation, string group)
        {
            tvManager.Nodes[collectionLocation].Nodes.Add(group);
        }

        public void AddQueryToManager(int groupLocation, string query)
        {
            tvManager.Nodes[0].Nodes[groupLocation].Nodes.Add(query);
        }

        public void ClearManager()
        {
            tvManager.Nodes.Clear();
        }

        public string GetCurrentManagerSelection()
        {
            return tvManager.SelectedNode.Text;
        }

        public string GetCurrentCollection()
        {
            ManagerProperty selectedProperty = GetSelectedManagerProperty();
            if (selectedProperty == ManagerProperty.COLLECTION) return tvManager.SelectedNode.Text;
            else if (selectedProperty == ManagerProperty.GROUP) return tvManager.SelectedNode.Parent.Text;
            else if (selectedProperty == ManagerProperty.QUERY) return tvManager.SelectedNode.Parent.Parent.Text;
            else return "";
        }
        public string GetCurrentGroup()
        {
            ManagerProperty selectedProperty = GetSelectedManagerProperty();
            if (selectedProperty == ManagerProperty.GROUP) return tvManager.SelectedNode.Text;
            else if (selectedProperty == ManagerProperty.QUERY) return tvManager.SelectedNode.Parent.Text;
            else return "";
        }
        public string GetCurrentQuery()
        {
            ManagerProperty selectedProperty = GetSelectedManagerProperty();
            if (selectedProperty == ManagerProperty.QUERY) return tvManager.SelectedNode.Text;
            else return "";
        }

        public void SetManagerCurrentSelection(int collection, int group, int query)
        {
            if (collection >= 0 && group < 0 && query < 0)
                tvManager.SelectedNode = tvManager.Nodes[collection];
            else if (collection >= 0 && group >= 0 && query < 0)
                tvManager.SelectedNode = tvManager.Nodes[collection].Nodes[group];
            else if (collection >= 0 && group >= 0 && query >= 0)
                tvManager.SelectedNode = tvManager.Nodes[collection].Nodes[group].Nodes[query];
            tvManager.Select();
        }

        public void SetUpManager()
        {
            tvManager.Nodes[0].ExpandAll();
        }

        public ManagerProperty GetSelectedManagerProperty()
        {
            if (tvManager.SelectedNode.Level == 0) return ManagerProperty.COLLECTION;
            else if (tvManager.SelectedNode.Level == 1) return ManagerProperty.GROUP;
            else if (tvManager.SelectedNode.Level == 2) return ManagerProperty.QUERY;
            else return ManagerProperty.UNDEFINED;
        }

        public void UpdateAddNewSelectorText(string text)
        {
            btnAddNew.Text = text;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.OnStartUp();
        }

        public void LoadDisplay(UserControl uc)
        {
            pDisplay.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pDisplay.Controls.Add(uc);
        }

        private void tvManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvManager.SelectedNode = tvManager.GetNodeAt(e.X, e.Y);
            }
        }

        
    }
}
