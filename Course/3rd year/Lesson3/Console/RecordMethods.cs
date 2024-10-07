namespace Lesson3Record;

public class RecordMethods
{
    private CSVRecordRW CSVMethods = new CSVRecordRW();
    public List<Record> _records { get; set; }
    public RecordMethods(List<Record> records){
        _records = records;
    }

    public void AddRecord(string filePath, Record record){
        if (record != null){
            _records.Add(record);
            CSVMethods.WriteRecord(filePath, _records);
        }
    }

    public void UpdateRecord(string filePath, int index, Record record){
        if (index >= 0 && index < _records.Count && record != null){
            _records[index] = record;
            CSVMethods.WriteRecord(filePath, _records);
        }
    }

    public void DeleteRecord(string filePath, int index){
        if (index >= 0 && index < _records.Count){
            _records.RemoveAt(index);
            CSVMethods.WriteRecord(filePath, _records);
        }
    }

    public Record GetRecord(int index){
        if (index >= 0 && index < _records.Count) return _records[index];
        return null;
    }

    public List<Record> GetRecords(){
        return _records;
    }
}