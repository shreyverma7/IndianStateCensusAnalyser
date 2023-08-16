using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CSVStateCensus
    {
        public static int ReadStateCensusData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCencusData>().ToList();
                    Console.WriteLine("Read Data From CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.State + "---" + data.Population + "---" + data.AreaInSqKm + "---" + data.DensityPerSqKm);
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
