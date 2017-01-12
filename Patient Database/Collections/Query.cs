using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Collections
{
    public class Query
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public string Statement { get; set; }

        public Query(string name, string info, string statement)
        {
            Name = name;
            Info = info;
            Statement = statement;
        }
    }
}
