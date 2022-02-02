using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventModel
{
    public class CountryEvents
    {
        private int marker = 0;
        private int endMarker = 0;

        private List<CountryData> countryDataCollection = new List<CountryData>();
        public string FileName
        {
            get;
            set;
        }

        public void Initialize(string file)
        {
            FileName = file;
            marker = 0;
            countryDataCollection.Clear();

            if (!File.Exists(FileName))
            {
                throw new Exception(String.Format("File {0} does not exist", FileName));
            }

            StreamReader reader = new StreamReader(FileName);
            string line;

            while ((line = reader.ReadLine()) != null){
                var countryData = JsonConvert.DeserializeObject<CountryData>(line);
               // var countryData=JsonConvert.DeserializeObject<List<CountryData>>(line);
                //var myObj = countryData[0];
                countryDataCollection.Add(countryData);
                endMarker += 1;
            }
        }

        public List<CountryData> GetBatch(int size = 50)
        {
            var list = new List<CountryData>();
            int end = ((marker + size) > endMarker) ? endMarker : marker + 50;
            
            for (var i = marker; i < end; i++)
            {
                list.Add(countryDataCollection[i]);
            }
            return list;
        }
    }
}
