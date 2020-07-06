using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ShwNewsCheck
{
    [Serializable]
    public class NewsSpecItem
    {
        private string shareName;
        private string shareNumber;
        private string searchTerms;

        public string ShareName { get => shareName; set => shareName = value; }
        public string ShareNumber { get => shareNumber; set => shareNumber = value; }
        public string SearchTerms { get => searchTerms; set => searchTerms = value; }


        public static ICollection<NewsSpecItem> DeserializeAllTable<NewsSpecItem>(FileStream fs)
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<NewsSpecItem> list = new List<NewsSpecItem>();
            while (fs.Position != fs.Length)
            {
                //deserialize each object in the file
                var deserialized = (NewsSpecItem)bf.Deserialize(fs);
                //add individual object to a list
                list.Add(deserialized);
            }
            //return the list of objects
            return list;
        }


    }



}
