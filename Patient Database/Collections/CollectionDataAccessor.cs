using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Database.Collections
{
    public class CollectionDataAccessor
    {
        // gets specified collection from files
        public Collection GetCollection(string collectionName)
        {
            // if no collectionName inputted, try to get default collection stated in settings file
            try
            {
                if (collectionName == "")
                    collectionName = GetDefaultCollection();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: Settings file not found!");
            }
            
            // create collection. If file is not found, collection cannot be created -- returns null in that case
            try
            {
                IEnumerable<String> file = File.ReadLines(new StringBuilder()
                    .Append(@"Manager\Collections\")
                    .Append(collectionName)
                    .Append(@"\")
                    .Append(collectionName)
                    .Append(".txt")
                    .ToString());

                Collection collection = new Collection(file.ElementAt(1).Split(':')[1], file.ElementAt(2).Split(':')[1]); // creates collection
                collection.Groups = GetGroups(collection.Name); // loads groups
                foreach (KeyValuePair<string, Group> group in collection.Groups) // for each group, load its queries
                    group.Value.Queries = GetQueries(collection.Name, group.Key);                    
              
                return collection;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: " + collectionName + " File not found. Collection could not be imported!");
            }
            return null;
        }

        // gets default collection stated in settings file
        private string GetDefaultCollection()
        {
            return File.ReadLines(@"Manager\Settings.txt").ElementAt(0).Split(':')[1];
        }

        // gets groups for a collection
        private SortedDictionary<string, Group> GetGroups(string collectionName)
        {
            SortedDictionary<string, Group> groups = new SortedDictionary<string, Group>();

            // access collection's groups directory
            try
            {
                DirectoryInfo directory = new DirectoryInfo(new StringBuilder()
                    .Append(@"Manager\Collections\")
                    .Append(collectionName)
                    .Append(@"\Groups\")
                    .ToString());
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (DirectoryInfo d in directories) // loads in each group file
                {
                    try
                    {
                        IEnumerable<string> file = File.ReadLines(new StringBuilder()
                            .Append(@"Manager\Collections\")
                            .Append(collectionName)
                            .Append(@"\Groups\")
                            .Append(d.Name)
                            .Append(@"\")
                            .Append(d.Name)
                            .Append(".txt")
                            .ToString());
                        groups.Add(d.Name, new Group(d.Name, file.ElementAt(2).Split(':')[1]));
                    }
                    catch(FileNotFoundException)
                    {
                        Console.WriteLine("Error: Group " + d.Name + " file not found!");
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Group directory for Collection " + collectionName + " not found!");
            }
            return groups;
        }

        // gets queries for a group
        private SortedDictionary<string, Query> GetQueries(string collectionName, string groupName)
        {
            SortedDictionary<string, Query> queries = new SortedDictionary<string, Query>();

            // accesses group's queries directory
            try
            {
                string[] files = Directory.GetFiles(new StringBuilder()
                    .Append(@"Manager\Collections\")
                    .Append(collectionName)
                    .Append(@"\Groups\")
                    .Append(groupName)
                    .Append(@"\Queries\")
                    .ToString());

                foreach (string f in files) // loads in queries for each group
                {
                    IEnumerable<string> file = File.ReadLines(f);
                    queries.Add(file.ElementAt(1).Split(':')[1], new Query(
                        file.ElementAt(1).Split(':')[1], file.ElementAt(2).Split(':')[1], file.ElementAt(3).Split(':')[1]));
                }
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Error: Queries directory for Group " + groupName + " not found!");
            }

            return queries;
        }


    }
}
