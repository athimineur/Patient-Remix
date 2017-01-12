using Patient_Database.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Manager.Info
{
    public class InfoPresenter
    {
        InfoUC view;

        public InfoPresenter(InfoUC view)
        {
            this.view = view;
        }

        public void ClearOldInfo()
        {
            view.ClearInfoText();
        }

        public void LoadNewInfo(string text)
        {
            view.AddInfoText(text);
        }


        public void UpdateInfo(Collection collection, string collectionName)
        {
            view.AddInfoText(GetCollectionInfo(collection, collectionName));
        }

        public void UpdateInfo(Collection collection, string collectionName, string groupName)
        {
            view.AddInfoText(GetGroupInfo(collection, collectionName, groupName));
        }

        public void UpdateInfo(Collection collection, string collectionName, string groupName, string queryName)
        {
            view.AddInfoText(GetQueryInfo(collection, collectionName, groupName, queryName));
        }

        public string GetCollectionInfo(Collection collection, string collectionName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: Collection")
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Name: ")
                .Append(collection.Name)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Info: ")
                .Append(collection.Info)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Included Groups")
                .Append(Environment.NewLine);
            foreach (Group g in collection.Groups.Values)
            {
                sb.Append("    ")
                  .Append(g.Name)
                  .Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        public string GetGroupInfo(Collection collection, string collectionName, string groupName)
        {
            StringBuilder sb = new StringBuilder();
            Group selectedGroup = collection.Groups[groupName];
            sb.Append("Type: Group")
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Name: ")
                .Append(selectedGroup.Name)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Info: ")
                .Append(selectedGroup.Info)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Included Queries: ")
                .Append(Environment.NewLine);
            foreach (Query q in selectedGroup.Queries.Values)
            {
                sb.Append("    ")
                  .Append(q.Name)
                  .Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        public string GetQueryInfo(Collection collection, string collectionName, string groupName, string queryName)
        {
            StringBuilder sb = new StringBuilder();
            Query selectedQuery = collection.Groups[groupName].Queries[queryName];
            sb.Append("Type: Query")
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Name: ")
                .Append(selectedQuery.Name)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Info: ")
                .Append(selectedQuery.Info)
                .Append(Environment.NewLine)
                .Append(Environment.NewLine)
                .Append("Statement:")
                .Append(Environment.NewLine);
            foreach (string s in selectedQuery.Statement.Split(new string[] { " / " }, StringSplitOptions.None))
            {
                sb.Append("    ")
                  .Append(s)
                  .Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
