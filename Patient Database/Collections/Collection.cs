using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Collections
{
    public class Collection
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public SortedDictionary<string, Group> Groups { get; set; }

        public Collection(string name, string info)
        {
            Name = name;
            Info = info;
            Groups = new SortedDictionary<string, Group>();
        }
    }
}
