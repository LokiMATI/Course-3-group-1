namespace MyWebSolution.Models.Core
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Task(string _Name, string _Description, string _Type)
        {
            Name = _Name;
            Description = _Description;
            Type = _Type;
        }
    }
}
