using Patient_Database.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Manager
{
    public class ManagerModel
    {
        static Collection collection;
        public Collection Collection
        {
            get { return collection; }
        }

        public void LoadDefaultCollection()
        {
            collection = new CollectionDataAccessor().GetCollection("");
        }

    }
}
