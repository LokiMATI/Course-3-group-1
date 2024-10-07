using CsvHelper;
using System.Globalization;

namespace Lesson3Record;

public class CSVRecordRW
{
    public void WriteRecord(string filePath, List<Record> records){

        using (var write = new StreamWriter(filePath))
        using (var csv = new CsvWriter(write, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture))){
            csv.WriteRecords(records);
        }
    }

    public List<Record> ReadRecord(string filePath)
    {
        using (var read = new StreamReader(filePath))
        using (var csv = new CsvReader(read, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)))
        {
            return csv.GetRecords<Record>().ToList();
        }
    }
}