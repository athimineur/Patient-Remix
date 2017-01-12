using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Collections
{
    public class Group
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public SortedDictionary<string, Query> Queries { get; set; }

        public Group(string name, string info)
        {
            Name = name;
            Info = info;
            Queries = new SortedDictionary<string, Query>();
        }
    }
}
